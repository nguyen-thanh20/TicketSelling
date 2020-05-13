using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicketSelling.Manager;

namespace TicketSelling
{
    public partial class ManagerForm : Form
    {
        private SQL sql;
        private string ID;
        private List<Form> tempForm;
        private Form curForm;
        public ManagerForm(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            tempForm = new List<Form>();
        }

        private void ShowChildForm(Form child)
        {
            if (tempForm.Count != 0)
            {
                foreach (var x in tempForm)
                {
                    if (x.GetType() == child.GetType())
                    {
                        curForm.Hide();
                        x.BringToFront();
                        x.Show();
                        curForm = x;
                        return;
                    }
                }
            }
            curForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Top;
            RightPanel.Controls.Add(child);
            tempForm.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void DriverBt_Click(object sender, EventArgs e)
        {
            ShowChildForm(new DriverManager(sql, ID));
        }

        private void TripBt_Click(object sender, EventArgs e)
        {
            ShowChildForm(new TripManagerForm(sql, ID));
        }

        private void UserBt_Click(object sender, EventArgs e)
        {
            ShowChildForm(new UserManagerForm(sql, ID));
        }
    }
}
