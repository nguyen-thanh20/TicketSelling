using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class SignUpForm : Form
    {
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataReader dataReader;
        string query, role;
        int ID;
        public SignUpForm(SqlConnection sql)
        {
            this.sql = sql;
            InitializeComponent();
        }

        private void PwCfTb_TextChanged(object sender, EventArgs e)
        {
            if (PwTb.Text != PwCfTb.Text)
            {
                confirmpwlb.ForeColor = Color.Red;
                checkPwLb.Visible = true;
            }else
            {
                confirmpwlb.ForeColor = Color.Black;
                checkPwLb.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (RoleListBox.SelectedItem.ToString() == "Member")
            {
                role = "USERS";
            }
            else
            {
                role = "MANAGER";
            }

            query = String.Format("INSERT INTO {0} VALUES ('{1}','{2}','{3}','{4}','{5}','{6}'); ",
                role,
                nametb.Text,
                PhoneTb.Text,
                AddressTb.Text,
                EmailTb.Text,
                GenderListBox.SelectedItem.ToString(),
                DoBTb.Value.ToString("yyyy-MM-dd"));
            cmd = new SqlCommand(query, sql);

            cmd.ExecuteNonQuery();

            query = String.Format("SELECT TOP 1 * FROM {0} ORDER BY ID DESC;", role);
            cmd = new SqlCommand(query, sql);

            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ID = (int)dataReader.GetValue(0);
            }
            sql.Close();
            sql.Open();
            if (role == "USERS") 
            {
                query = String.Format("INSERT INTO ACCOUNT VALUES ('{0}','{1}',{2},NULL)",
                    UsTb.Text, PwTb.Text, ID);
            }
            else
            {
                query = String.Format("INSERT INTO ACCOUNT VALUES ('{0}','{1}',NULL,{2})",
                    UsTb.Text, PwTb.Text, ID);
            }

            cmd = new SqlCommand(query, sql);
            cmd.ExecuteNonQuery();

            sql.Close();
            this.Close();
        }
    }
}
