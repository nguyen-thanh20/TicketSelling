using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling.Manager
{
    public partial class ControlForm : Form
    {
        private SQL sql;
        private string ID_Mana, ID_Trip;
        public ControlForm(SQL sql, string ID_Mana)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID_Mana = ID_Mana;
            init();
        }

        private void init()
        {
            string query = "select Source, " +
                                    "Destination," +
                                    "Date_Trip," +
                                    "Start_Time," +
                                    "Arrival_Time," +
                                    "Duration," +
                                    "Total_Seat," +
                                    "Price," +
                                    "Discount," +
                                    "ID_Driver, " +
                                    "ID_Trip " +
                                    "from TRIP";
            DataShow.DataSource = sql.Read(query).Tables[0];
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SourceTb.Text       = DataShow[0, e.RowIndex].Value.ToString();
                DestinationTb.Text  = DataShow[1, e.RowIndex].Value.ToString();
                DateTripTb.Value    = (DateTime) DataShow[2, e.RowIndex].Value;
                StartTimeTb.Text    = DataShow[3, e.RowIndex].Value.ToString();
                ArrivalTimeTb.Text  = DataShow[4, e.RowIndex].Value.ToString();
                TotalSeatTb.Text    = DataShow[6, e.RowIndex].Value.ToString();
                PriceTb.Text        = DataShow[7, e.RowIndex].Value.ToString();
                DiscountTb.Text     = DataShow[8, e.RowIndex].Value.ToString();
                DriverIDTb.Text     = DataShow[9, e.RowIndex].Value.ToString();
                ID_Trip             = DataShow[10, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
