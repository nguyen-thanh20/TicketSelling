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

namespace Manager
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            Shown += Form2_Shown;
            {
                this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            }
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            Load("select * from TRIP");
            button6.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = true;
            ShowDetail(false);
            panel9.Visible = false;
        }
        private void Load(String sql)
        {
            DataSet ds = new DataSet();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-00L2TGG;Initial Catalog=TicketSelling1;Integrated Security=True";
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("IDTrip will be given randomly by system", "Notification", MessageBoxButtons.OK) == DialogResult.OK)
            {
                textBox12.Enabled = false;
                label4.Text = "ADD";
                DeleteDetail();
                textBox12.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                ShowDetail(true);
            }

        }
        private void DeleteDetail()
        {
            textBox12.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }
        private void ShowDetail(Boolean showup)
        {
            textBox12.Enabled = false;
            textBox5.Enabled = showup;
            textBox6.Enabled = showup;
            dateTimePicker1.Enabled = showup;
            textBox3.Enabled = showup;
            textBox4.Enabled = showup;
            textBox8.Enabled = showup;
            textBox9.Enabled = showup;
            textBox10.Enabled = showup;
            textBox11.Enabled = showup;
            button8.Enabled = showup;
            button9.Enabled = showup;
            textBox16.Enabled = showup;
            textBox17.Enabled = showup;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button5.Enabled = false;
            try
            {
                textBox12.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1[4, e.RowIndex].Value;
                textBox3.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                textBox16.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                textBox17.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                textBox8.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                textBox9.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                textBox10.Text = dataGridView1[11, e.RowIndex].Value.ToString();
                textBox11.Text = dataGridView1[12, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "UPDATE";
            button5.Enabled = false;
            button7.Enabled = false;
            ShowDetail(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete " + textBox5.Text + " \n\tIf Yes,Save, NO Cancel", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                label4.Text = "DELETE";
                button5.Enabled = false;
                button6.Enabled = false;
                ShowDetail(true);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {       
                button7.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = true;
                DeleteDetail();
                ShowDetail(false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (con.State != ConnectionState.Open)
                con.Open();
            if (textBox5.Text.Trim() == "")
            {
                errChitiet.SetError(textBox5, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }

            if(textBox6.Text.Trim() == "")
            {
                errChitiet.SetError(textBox6, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox16.Text.Trim() == "")
            {
                errChitiet.SetError(textBox16, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox17.Text.Trim() == "")
            {
                errChitiet.SetError(textBox17, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox3.Text.Trim() == "")
            {
                errChitiet.SetError(textBox3, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox4.Text.Trim() == "")
            {
                errChitiet.SetError(textBox4, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox8.Text.Trim() == "")
            {
                errChitiet.SetError(textBox8, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox9.Text.Trim() == "")
            {
                errChitiet.SetError(textBox9, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox10.Text.Trim() == "")
            {
                errChitiet.SetError(textBox10, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            if (textBox11.Text.Trim() == "")
            {
                errChitiet.SetError(textBox11, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
            }
            sql = "INSERT INTO TRIP(Source, Destination, Date_Trip,Start_Time,Arrival_Time, Total_Seat, Price, Discount, ID_Driver,Duration, Available_Seat) VALUES (";
            sql += "'" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value.Date + "','"+textBox3.Text+ "','"+textBox4.Text+ "',"+textBox8.Text+ ","+textBox9.Text+ ","+ textBox10.Text+ ",'"+textBox11.Text+"','"+textBox16.Text+"',"+textBox17.Text+");";
            if (button6.Enabled == true)
            {
                sql = "Update TRIP SET ";
                sql += "[Source] = '" + textBox5.Text + "',";
                sql += "[Destination] = '" + textBox6.Text + "',";
                sql += "[Date_Trip] = '" + dateTimePicker1.Value.Date + "',";
                sql += "[Start_Time] = '" + textBox3.Text + "',";
                sql += "[Arrival_Time] = '" + textBox4.Text + "',";
                sql += "[Total_Seat] = '" + textBox8.Text + "',";
                sql += "[Price] = '" + textBox9.Text + "',";
                sql += "[Discount] = '" + textBox10.Text + "',";
                sql += "[Duration] = '" + textBox16.Text + "',";
                sql += "[Available_Seat] = '" + textBox17.Text + "',";
                sql += "[ID_Driver] = '" + textBox11.Text + "'";
                sql += "Where [ID_Trip] ='" + textBox12.Text + "';";
            }
            if (button7.Enabled == true)
            {
                sql = "Delete From TRIP Where [ID_Trip] ='" + textBox12.Text + "';";
            }
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            sql = "Select * from TRIP";
            Load(sql);
            con.Close();
            DeleteDetail();
            ShowDetail(false);
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel9.Visible = true;
            if ((comboBox1.SelectedItem.ToString() == "TripID") && ((panel6.Visible == true) || (panel7.Visible == true) || (panel8.Visible == true) || (panel5.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "TripID")
                panel4.Visible = true;
            }
            if ((comboBox1.SelectedItem.ToString() == "StartDate") && ((panel6.Visible == true) || (panel7.Visible == true) || (panel8.Visible == true) || (panel4.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "StartDate")
                    panel5.Visible = true;
            }
            if ((comboBox1.SelectedItem.ToString() == "Source") && ((panel5.Visible == true) || (panel7.Visible == true) || (panel8.Visible == true) || (panel4.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Source")
                    panel6.Visible = true;
            }
            if ((comboBox1.SelectedItem.ToString() == "Destination") && ((panel5.Visible == true) || (panel6.Visible == true) || (panel8.Visible == true) || (panel4.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Destination")
                    panel7.Visible = true;
            }
            if ((comboBox1.SelectedItem.ToString() == "DriverID") && ((panel5.Visible == true) || (panel6.Visible == true) || (panel7.Visible == true) || (panel4.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "DriverID")
                    panel8.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM TRIP";
            if (textBox7.Text.Trim() == "")
            {
                errChitiet.SetError(textBox7, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where ID_Trip like '%" + textBox7.Text + "%'";
            }
            Load(sql);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM TRIP";
            if (dateTimePicker2.Value.Date.ToString() != "")
            {
                sql += " Where Date_Trip = '" + dateTimePicker2.Value.Date.ToString("MM/dd/yyyy") + "';";
            }
            Load(sql);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM TRIP";
            if (textBox13.Text.Trim() == "")
            {
                errChitiet.SetError(textBox13, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where Source like '%" + textBox13.Text + "%'";
            }
            Load(sql);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM TRIP";
            if (textBox14.Text.Trim() == "")
            {
                errChitiet.SetError(textBox14, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where Destination like '%" + textBox14.Text + "%'";
            }
            Load(sql);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            Load("select * from TRIP");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM TRIP";
            if (textBox15.Text.Trim() == "")
            {
                errChitiet.SetError(textBox15, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where ID_Driver like '%" + textBox15.Text + "%'";
            }
            Load(sql);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}


