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
    public partial class GuestList : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public GuestList()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
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
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Load("select u.* from TICKET t, USERS u, TRIP tr where (t.ID_Trip = '" +textBox1.Text+ "') AND (tr.ID_Trip = '" +textBox1.Text+"') AND (t.ID_User=u.ID_User) order by u.ID_User");
        }
    }
}
