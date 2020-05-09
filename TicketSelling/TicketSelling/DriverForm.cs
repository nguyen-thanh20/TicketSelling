using System;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class DriverForm : Form
    {
        private string ID;
        private SQL sql;
        public DriverForm(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void loadData()
        {
            string start = startDay.Value.ToString("yyyy-MM-dd");
            string end = endDay.Value.ToString("yyyy-MM-dd");

            string query = string.Format("select " +
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
            DriverGridView.DataSource = sql.Read(query).Tables[0];
        }
        private void DriverForm_Load(object sender, EventArgs e)
        {
            string query = string.Format("select " +
                "Source, " +
                "Destination, " +
                "Date_Trip, " +
                "Start_Time, " +
                "Arrival_Time, " +
                "Duration, " +
                "Total_Seat, " +
                "Available_Seat from TRIP " +
                "WHERE ID_Driver = '{0}' ", ID);
            DriverGridView.DataSource = sql.Read(query).Tables[0];
        }

        private void CheckBt_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
