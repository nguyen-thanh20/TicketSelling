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
        string default_query = "select Source, " +
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
                                    "from TRIP ";
        public ControlForm(SQL sql, string ID_Mana)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID_Mana = ID_Mana;
            init();
        }

        private void init()
        {
            DataShow.DataSource = sql.Read(default_query).Tables[0];
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            string col;
            string query, from = default, search = default;
            bool blank = false;
            if (isBlank(SearchCB))
                blank = true;

            if (isBlank(SearchTb))
            {
                if (isBlank(SearchFromTb))
                {
                    blank = true;
                }
                else from = sql.checkQuote(SearchFromTb.Text);
            }
            else search = sql.checkQuote(SearchTb.Text);

            if (blank)
            {
                DataShow.DataSource = sql.Read(default_query).Tables[0];
                return;
            }

            col = SearchCB.SelectedItem.ToString();

            if (string.Equals(col, "Source - Destination"))
            {
                query = string.Format("{0} WHERE Source like '{1}%' AND Destination like '{2}%'", default_query, from, search);
            }
            else
                query = string.Format("{0} WHERE {1} like '{2}%'", default_query, col, search);
            DataShow.DataSource = sql.Read(query).Tables[0];
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

        private void SearchCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.Equals(SearchCB.SelectedItem.ToString(), "Source - Destination"))
            {
                SearchFromTb.Show();
                SourceLb.Show();
            }
            else
            {
                SearchFromTb.Hide();
                SourceLb.Hide();
            }
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
