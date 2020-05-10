﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Manager;

namespace TicketSelling
{
    public partial class ManagerForm : Form
    {
        private SQL sql;
        private string ID;
        private List<Form> tempForm;
        public ManagerForm(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID  = ID;
            tempForm = new List<Form>();
        }

        private void ControlBt_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ControlForm(sql,ID));
        }

        private void ShowChildForm(Form child)
        {
            if(tempForm.Count != 0)
            {
                foreach(var x in tempForm)
                {
                    if(x.GetType() == child.GetType())
                    {
                        tempForm[tempForm.Count-1].Hide();
                        x.BringToFront();
                        x.Show();
                        return;
                    }
                }
            }
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Top;
            RightPanel.Controls.Add(child);
            tempForm.Add(child);
            child.BringToFront();
            child.Show();
        }
    }
}