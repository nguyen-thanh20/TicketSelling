using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketSelling
{
    public partial class SignInForm : Form
    {
        public SqlConnection sql;
        SqlCommand cmd;
        SqlDataReader dataReader;
        string query, role;
        public SignInForm()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DOKUSLAPTOP\\DOKUSQL";
            builder.UserID = "sa";
            builder.Password = "123";
            builder.InitialCatalog = "TicketSelling";

            sql = new SqlConnection(builder.ConnectionString);

            //SqlConnection sql = new SqlConnection(conString);
            //sql.Open();

        }

        private string checkQuote(string str)
        {
            if (str.Contains("'"))
            {
                str = str.Insert(str.IndexOf("'"), "'");
            }
            return str;
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            string us = checkQuote(UsernameTextbox.Text);
            string pw = checkQuote(PasswordTextbox.Text);

            //Check quote character
            

            sql.Open();

            query = "SELECT * FROM ACCOUNT" +
                " WHERE Username = '"+us+ "' COLLATE Latin1_General_CS_AS AND Pass_Account='" + pw+ "' COLLATE Latin1_General_CS_AS";
            cmd = new SqlCommand(query, sql);
            dataReader = cmd.ExecuteReader();
            if (!dataReader.Read())
            {
                MessageBox.Show("Wrong Username or Password!"); 
            }
            else 
            {
                string ID = (string)dataReader.GetValue(2);
                sql.Close();
                
                sql.Open();
                query = string.Format("SELECT Last_name from USERS " +
                    "WHERE ID_User = '{0}'",ID);
                cmd = new SqlCommand(query, sql);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    MessageBox.Show("Welcome " + dataReader.GetValue(0));
                }
                sql.Close();
                role = getRole(ID);
                if(role == "Driver")
                {
                    this.Hide();
                    var driverForm = new DriverForm(sql, ID);
                    driverForm.Show();
                    driverForm.Closed += (s, arg) => this.Close();
                }
            }
            sql.Close();
        }

        private string getRole(string ID)
        {
            string role="";
            sql.Open();
            query = string.Format("SELECT Role_User " +
                "FROM USERS " +
                "WHERE ID_User = '{0}'",ID);
            cmd = new SqlCommand(query, sql);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                role = (string)dataReader.GetValue(0);
            }
            sql.Close();
            return role;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm(sql);
            signup.Show();
        }

        //  public string conString = "Data Source=DOKUSLAPTOP;Initial Catalog=TestConnectSQL;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            //sql.Open();
            //query = "SELECT * FROM ACCOUNT";

            //cmd = new SqlCommand(query, sql);

            //dataReader = cmd.ExecuteReader();

            //while (dataReader.Read())
            //{

            //    Output += dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);
            //sql.Close();
        }
    }
}
