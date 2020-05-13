using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling.Manager
{
    public partial class UserManagerForm : Form
    {
        private SQL sql;
        private string ID,
            default_query = "select ID_User, First_Name, Last_Name, Phone, Address_User, " +
                "Email, Gender_User, Date_Of_Birth from USERS ";
        public UserManagerForm(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            LoadData();
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataShow.RowCount-1) //Return when user click on top of col or row
                return;
            try
            {
                UserIDTb.Text = DataShow[0, e.RowIndex].Value.ToString();
                FirstNameTb.Text = DataShow[1, e.RowIndex].Value.ToString();
                LastNameTb.Text = DataShow[2, e.RowIndex].Value.ToString();
                PhoneTb.Text = DataShow[3, e.RowIndex].Value.ToString();
                AddressTb.Text = DataShow[4, e.RowIndex].Value.ToString();
                EmailTb.Text = DataShow[5, e.RowIndex].Value.ToString();
                GenderListBox.Text = DataShow[6, e.RowIndex].Value.ToString().Trim();
                DoBTb.Value = (DateTime)DataShow[7, e.RowIndex].Value;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchCB.SelectedItem.ToString()) || string.IsNullOrEmpty(SearchTb.Text))
            {
                LoadData();
                return;
            }
            string query = string.Format("{0} WHERE Role_User = 'User' AND {1} like '{2}%'",
               default_query, SearchCB.SelectedItem.ToString(), sql.checkQuote(SearchTb.Text));
            DataShow.DataSource = sql.Read(query).Tables[0];
        }

        private void SearchCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.Equals(SearchCB.SelectedItem.ToString(), "Date_Of_Birth"))
            {
                warningDateInputLb.Visible = true;
            }
            else warningDateInputLb.Visible = false;
        }

        private bool LoadData()
        {
            DataShow.DataSource = sql.Read(default_query + "WHERE Role_User = 'User'").Tables[0];
            return true;
        }


    }
}
