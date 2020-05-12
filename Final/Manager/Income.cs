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
    public partial class Income : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Income()
        {
            InitializeComponent();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            Shown += Form6_Shown;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel9.Visible = false;
        }
        private void Form6_Shown(object sender, EventArgs e)
        {
            Load("select SUM((Total_Seat - Available_Seat)*Price) AS [Overall Income] from TRIP");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            if ((comboBox1.SelectedItem.ToString() == "Trip") && ((panel11.Visible == true) || (panel12.Visible == true) || (panel13.Visible == true) || (panel14.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Trip")
                {
                    panel10.Visible = true;
                    Load("Select ID_Trip, ((Total_Seat - Available_Seat)*Price) AS Income From TRIP order by ID_Trip ASC; ");
                }

            }
            if ((comboBox1.SelectedItem.ToString() == "Date") && ((panel14.Visible == true) || (panel10.Visible == true) || (panel12.Visible == true) || (panel13.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Date")
                {
                    panel11.Visible = true;
                    Load("Select Date_Trip, Sum((Total_Seat - Available_Seat)*Price) AS Income From TRIP Group by Date_Trip order by Date_Trip DESC;");
                }
            }
            if ((comboBox1.SelectedItem.ToString() == "Source") && ((panel10.Visible == true) || (panel11.Visible == true) || (panel13.Visible == true) || (panel14.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Source")
                { 
                    panel12.Visible = true;
                    Load("Select Source, Sum((Total_Seat - Available_Seat)*Price) AS Income From TRIP Group by Source order by Source DESC;"); 
                }
            }
            if ((comboBox1.SelectedItem.ToString() == "Destination") && ((panel10.Visible == true) || (panel11.Visible == true) || (panel12.Visible == true) || (panel14.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Destination")
                {
                    panel13.Visible = true;
                    Load("Select Destination, Sum((Total_Seat - Available_Seat)*Price) AS Income From TRIP Group by Destination order by Destination DESC;");
                }
            }
            if ((comboBox1.SelectedItem.ToString() == "Driver") && ((panel10.Visible == true) || (panel11.Visible == true) || (panel12.Visible == true) || (panel13.Visible == true)))
            {
                errChitiet.SetError(button16, "Exit before Continue Searching");
                return;
            }
            else
            {
                errChitiet.Clear();
                if (comboBox1.SelectedItem.ToString() == "Driver")
                { 
                    panel14.Visible = true;
                    Load("Select ID_Driver, Sum((Total_Seat - Available_Seat)*Price) AS Income From TRIP Group by ID_Driver order by ID_Driver ASC;");
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load(String sql)
        {
            DataSet ds = new DataSet();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-00L2TGG;Initial Catalog=TicketSelling;Integrated Security=True";
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String sql = "SELECT Date_Trip, Sum((Total_Seat - Available_Seat)*Price) AS Income FROM TRIP ";
            if (dateTimePicker1.Value.Date.ToString() != "")
            {
                sql += " Where Date_Trip = '" + dateTimePicker1.Value.Date.ToString("MM/dd/yyyy") + "' Group by Date_Trip;";
            }
            Load(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "SELECT ID_Trip, ((Total_Seat - Available_Seat)*Price) AS Income FROM TRIP ";
            if (textBox1.Text.Trim() == "")
            {
                errChitiet.SetError(textBox1, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where ID_Trip = '" + textBox1.Text + "';";
            }
            Load(sql);        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            String sql = "SELECT Destination, Sum((Total_Seat - Available_Seat)*Price) AS Income FROM TRIP ";
            if (textBox2.Text.Trim() == "")
            {
                errChitiet.SetError(textBox2, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where Destination = '" + textBox2.Text + "' GROUP BY Destination;";
            }
            Load(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "SELECT ID_Driver, Sum((Total_Seat - Available_Seat)*Price) AS Income FROM TRIP ";
            if (textBox15.Text.Trim() == "")
            {
                errChitiet.SetError(textBox15, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where ID_Driver = '" + textBox15.Text + "' GROUP BY ID_Driver;";
            }
            Load(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql = "SELECT Source, Sum((Total_Seat - Available_Seat)*Price) AS Income FROM TRIP ";
            if (textBox3.Text.Trim() == "")
            {
                errChitiet.SetError(textBox3, "Blank");
                return;
            }
            else
            {
                errChitiet.Clear();
                sql += " Where Source = '" + textBox3.Text + "' GROUP BY Source;";
            }
            Load(sql);
        }
    }
}
