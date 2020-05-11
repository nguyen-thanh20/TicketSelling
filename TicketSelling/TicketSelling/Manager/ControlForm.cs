using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            DataLoader();
        }

        private void DataLoader()
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
                DataLoader();
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
                DestLb.Text = "Dest";
            }
            else
            {
                SearchFromTb.Hide();
                SourceLb.Hide();
                DestLb.Text = "Key";
            }
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SourceTb.Text))
                DetailGB.Enabled = true;
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            foreach(var x in DetailGB.Controls.OfType<TextBox>())
            {
                if (isBlank(x))
                {
                    MessageBox.Show("Please fill the blank field ==\"");
                    return;
                }
            }
            DateTime start = DateTime.ParseExact(StartTimeTb.Text, "HH:mm:ss", new DateTimeFormatInfo());
            DateTime end   = DateTime.ParseExact(ArrivalTimeTb.Text, "HH:mm:ss", new DateTimeFormatInfo());
            TimeSpan Duration = end.Subtract(start);

            string query = string.Format("UPDATE TRIP SET Source = '{0}', Destination = '{1}', Date_Trip = '{2}', Start_Time = '{3}', Arrival_Time = '{4}', " +
                "Duration = '{5}', Total_Seat = {6}, Price = '{7}', Discount = '{8}', ID_Driver = '{9}', ID_Manager = '{10}' " +
                "WHERE ID_Trip = '{11}'",
                SourceTb.Text, DestinationTb.Text, DateTripTb.Value.ToString(), start.ToString(), end.ToString(), Duration.ToString(),
                TotalSeatTb.Text, PriceTb.Text, DiscountTb.Text, DriverIDTb.Text, this.ID_Mana, this.ID_Trip);
            sql.Add(query);
            DataLoader();
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                SourceTb.Text = DataShow[0, e.RowIndex].Value.ToString();
                DestinationTb.Text = DataShow[1, e.RowIndex].Value.ToString();
                DateTripTb.Value = (DateTime)DataShow[2, e.RowIndex].Value;
                StartTimeTb.Text = DataShow[3, e.RowIndex].Value.ToString();
                ArrivalTimeTb.Text = DataShow[4, e.RowIndex].Value.ToString();
                TotalSeatTb.Text = DataShow[6, e.RowIndex].Value.ToString();
                PriceTb.Text = DataShow[7, e.RowIndex].Value.ToString();
                DiscountTb.Text = DataShow[8, e.RowIndex].Value.ToString();
                DriverIDTb.Text = DataShow[9, e.RowIndex].Value.ToString();
                ID_Trip = DataShow[10, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
