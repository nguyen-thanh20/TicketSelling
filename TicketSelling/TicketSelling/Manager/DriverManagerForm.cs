using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class DriverManager : Form
    {
        private SQL sql;
        private string ID_Mana, func, 
            default_query = "select ID_User, First_Name, Last_Name, Phone, Address_User, " +
                "Email, Gender_User, Date_Of_Birth from USERS";
        public DriverManager(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID_Mana = ID;
            LoadData();
        }

        private bool LoadData() // Load the default data
        {
            DataShow.DataSource = sql.Read(default_query).Tables[0];
            return true;
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) //Return when user click on top of col or row
                return;
            try
            {
                DriverIDTb.Text = DataShow[0, e.RowIndex].Value.ToString();
                FirstNameTb.Text = DataShow[1, e.RowIndex].Value.ToString();
                LastNameTb.Text = DataShow[2, e.RowIndex].Value.ToString();
                PhoneTb.Text = DataShow[3, e.RowIndex].Value.ToString();
                AddressTb.Text = DataShow[4, e.RowIndex].Value.ToString();
                EmailTb.Text = DataShow[5, e.RowIndex].Value.ToString();
                GenderListBox.SelectedItem = DataShow[6, e.RowIndex].Value.ToString().Trim();
                DoBTb.Value = (DateTime)DataShow[7, e.RowIndex].Value;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            DetailGB.Enabled = true;
            DriverIDTb.Enabled = false;
            func = "Add";
            saveBt.Text = "Add";
        }

        private bool isBlank(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.BackColor = Color.LightCoral;
                return true;
            }
            else
                tb.BackColor = Color.White;
            return false;
        }

        private bool isBlank(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                cb.BackColor = Color.LightCoral;
                return true;
            }
            else
                cb.BackColor = Color.White;
            return false;
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            foreach (var x in DetailGB.Controls.OfType<TextBox>()) //Check blank boxes
            {
                if (isBlank(x))
                {
                    MessageBox.Show("Please fill the blank field ==\"");
                    return;
                }
            }
            
            string query = default;

            if (!sql.IsValidEmail(EmailTb.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }

            if (func == "Edit")
            {
                query = string.Format("UPDATE USERS SET First_Name = '{0}', Last_Name = '{1}', Phone = {2}, Address_User = '{3}', Email = '{4}', " +
                    "Gender_User = '{5}', Date_Of_Birth = {6} " +
                    "WHERE ID_User = '{7}'",
                    sql.checkQuote(FirstNameTb.Text), sql.checkQuote(LastNameTb.Text), PhoneTb.Text,
                    sql.checkQuote(AddressTb.Text), sql.checkQuote(EmailTb.Text), GenderListBox.SelectedItem.ToString(),
                    DoBTb.Value.ToString("yyyy-MM-dd"), DriverIDTb.Text);
            }
            else if (func == "Add")
            {
                query = string.Format("INSERT INTO USERS VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                   sql.checkQuote(FirstNameTb.Text), sql.checkQuote(LastNameTb.Text), PhoneTb.Text, 
                   sql.checkQuote(AddressTb.Text), sql.checkQuote(EmailTb.Text), GenderListBox.SelectedItem.ToString(),
                    DoBTb.Value.ToString("yyyy-MM-dd"), "Driver");
            }
            sql.Add(query);
            LoadData();
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchCB.SelectedItem.ToString()) || string.IsNullOrEmpty(SearchTb.Text))
            {
                LoadData();
                return;
            }

            string query = string.Format("{0} WHERE {1} like '{2}%'",
                default_query, SearchCB.SelectedItem.ToString(), sql.checkQuote(SearchTb.Text));
            DataShow.DataSource = sql.Read(query).Tables[0];
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DetailGB.Enabled = false;
        }

        private void PhoneTb_KeyDown(object sender, KeyEventArgs e) //Accept only number
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DriverIDTb.Text))
                return;
            DetailGB.Enabled = true;
            func = "Edit";
            saveBt.Text = "Save";
        }
    }
}
