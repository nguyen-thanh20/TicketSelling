using System;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class SignInForm : Form
    {
        private SQL sql;

        public SignInForm()
        {
            InitializeComponent();
            sql = new SQL("DOKUSLAPTOP\\DOKUSQL", "sa", "123", "TicketSelling");
            //ChangeForm("Manager", "ID000003");
            //SqlConnection sql = new SqlConnection(conString);
            //sql.Open();
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            string us = sql.checkQuote(UsernameTextbox.Text);
            string pw = sql.checkQuote(PasswordTextbox.Text);

            //Check quote character
            string query = "SELECT * FROM ACCOUNT" +
                " WHERE Username = '" + us + "' COLLATE Latin1_General_CS_AS AND Pass_Account='" + pw + "' COLLATE Latin1_General_CS_AS";
            string ID = sql.Read(2, query);
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Wrong Username or Password!");
            }
            else
            {
                query = string.Format("SELECT Last_name from USERS " +
                    "WHERE ID_User = '{0}'", ID);
                string name = sql.Read(0, query);
                MessageBox.Show("Welcome " + name);

                string role = getRole(ID);
                ChangeForm(role,ID);
            }
        }

        private void ChangeForm(string role, string ID)
        {
            if (role == "Driver")
            {
                this.Hide();
                var driverForm = new DriverForm(sql, ID);
                driverForm.Show();
                driverForm.Closed += (s, arg) => this.Close();
                return;
            }

            if (role == "Manager")
            {
                this.Hide();
                var managerForm = new ManagerForm(sql, ID);
                managerForm.Show();
                managerForm.Closed += (s, arg) => this.Close();
                return;
            }
        }

        private string getRole(string ID)
        {
            string role = "";
            string query = string.Format("SELECT Role_User " +
                "FROM USERS " +
                "WHERE ID_User = '{0}'", ID);
            return sql.Read(0, query);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm(sql);
            signup.Show();
            this.Hide();
            signup.FormClosed += (s,arg) =>this.Show();
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
