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
    public partial class Form1 : Form
    {
        public SqlConnection sql;
        SqlCommand cmd;
        SqlDataReader dataReader;
        string query, Output = "";
        public Form1()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DOKUSLAPTOP\\DOKUSQL";
            builder.UserID = "project";
            builder.Password = "123";
            builder.InitialCatalog = "TicketSelling";

            sql = new SqlConnection(builder.ConnectionString);

            //SqlConnection sql = new SqlConnection(conString);
            //sql.Open();

        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            string us = UsernameTextbox.Text;
            string pw = PasswordTextbox.Text;
            sql.Open();

            query = "SELECT Username,Pass_Account FROM ACCOUNT" +
                " WHERE Username = '"+us+"' AND Pass_Account='"+pw+"';";
            cmd = new SqlCommand(query, sql);
            dataReader = cmd.ExecuteReader();
            if (!dataReader.Read())
            {
                MessageBox.Show("Wrong"); 
            }
            else 
            {
                MessageBox.Show("Welcome " + us);
            }
            sql.Close();
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
               
            //    Output +=  dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);
            //sql.Close();
        }
    }
}
