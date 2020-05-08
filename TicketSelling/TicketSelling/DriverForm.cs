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
    public partial class DriverForm : Form
    {
        private string ID;
        private SqlConnection sql;
        private SqlCommand cmd;
        private string query;
        public DriverForm(SqlConnection sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void loadData()
        {
            string start = startDay.Value.ToString("yyyy-MM-dd");
            string end = endDay.Value.ToString("yyyy-MM-dd");

            sql.Open();
            query = string.Format("select " +
                "Source, " +
                "Destination, " +
                "Date_Trip, " +
                "Start_Time, " +
                "Arrival_Time, " +
                "Duration, " +
                "Total_Seat, " +
                "Available_Seat from TRIP " +
                "WHERE ID_Driver = '{0}' " +
                "AND Date_Trip >= '{1}' " +
                "AND Date_Trip <= '{2}'",
                ID, start, end);
            cmd = new SqlCommand(query, sql);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            DriverGridView.DataSource = ds.Tables[0];
            sql.Close();
        }
        private void DriverForm_Load(object sender, EventArgs e)
        {
            sql.Open();
            query = string.Format("select " +
                "Source, " +
                "Destination, " +
                "Date_Trip, " +
                "Start_Time, " +
                "Arrival_Time, " +
                "Duration, " +
                "Total_Seat, " +
                "Available_Seat from TRIP " +
                "WHERE ID_Driver = '{0}' ",ID);
            cmd = new SqlCommand(query, sql);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            DriverGridView.DataSource = ds.Tables[0];
            sql.Close();
        }

        private void CheckBt_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
