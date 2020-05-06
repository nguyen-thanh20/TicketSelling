using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class SignUpForm : Form
    {
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataReader dataReader;
        string query, ID;
        List<TextBox> tbList;
        List<Label> lbList;
        public SignUpForm(SqlConnection sql)
        {
            this.sql = sql;
            InitializeComponent();
            init();
        }
        private void init()
        {
            tbList = new List<TextBox>()
            {
                FirstNameTb, LastNameTb, AddressTb, PhoneTb, EmailTb, UsTb, PwTb, PwCfTb
            };

            lbList = new List<Label>()
            {
                FirstNameLb, LastNameLb, AddressLb, PhoneLb, EmailLb, UsernameLb, PasswordLb, confirmpwlb    
            };
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
        private Boolean IsBlank(TextBox t, int idx)
        {
            if(string.IsNullOrWhiteSpace(t.Text))
            {
                lbList[idx].ForeColor = Color.Red;
                return true;
            }
            return false;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void Confirm_click(object sender, EventArgs e)
        {
            //Check blank name
            bool blank = false;
            int index = 0;
            foreach (TextBox tb in tbList)
            {
                if (IsBlank(tb, index))
                    blank = true;
                index++;
            }

            if(GenderListBox.SelectedItem == null)
            {
                GenderLb.ForeColor = Color.Red;
                blank = true;
            }
            if (blank) return;

            if (!IsValidEmail(EmailTb.Text))
            {
                MessageBox.Show("Wrong Email format");
                return;
            }

            

            //Check dumplicate username
            sql.Open();
            query = string.Format("SELECT Username FROM ACCOUNT WHERE username='{0}'", UsTb.Text.ToString());
            cmd = new SqlCommand(query, sql);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
                if (dataReader.GetValue(0) != null)
                {
                    UsernameLb.ForeColor = Color.Red;
                    sql.Close();
                    return;
                }
            sql.Close();

            //Adding user infomations into database
            sql.Open();
            query = string.Format("INSERT INTO USERS VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','User')",
                FirstNameTb.Text,
                LastNameTb.Text,
                PhoneTb.Text,
                AddressTb.Text,
                EmailTb.Text,
                GenderListBox.SelectedItem.ToString(),
                DoBTb.Value.ToString("yyyy-MM-dd"));
            cmd = new SqlCommand(query, sql);
            cmd.ExecuteNonQuery();

            //Get user ID
            query = String.Format("SELECT TOP 1 * FROM USERS ORDER BY ID DESC;");
            cmd = new SqlCommand(query, sql);

            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ID = (string) dataReader.GetValue(1);
            }
            sql.Close();

            //Add user login infomation into Account table
            sql.Open();
            query = String.Format("INSERT INTO ACCOUNT VALUES ('{0}','{1}','{2}')",
            UsTb.Text, PwTb.Text, ID);
            cmd = new SqlCommand(query, sql);
            cmd.ExecuteNonQuery();

            sql.Close();
            this.Close();
        }

    }
}
