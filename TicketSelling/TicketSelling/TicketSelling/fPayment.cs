using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fPayment : Form
    {
        private string idTrip;
        private string idUser;
        private List<int> seat = new List<int>();
        private float totalprice;
        private List<Ticket> tickets = new List<Ticket>();
        public fPayment(string idTrip, string idUser, List<int> seat, float totalprice)
        {
            InitializeComponent();

            this.idTrip = idTrip;
            this.idUser = idUser;
            this.seat = seat;
            this.totalprice = totalprice;

            LoadPrice(this.totalprice);
        }

        private void lbPay_Click(object sender, EventArgs e)
        {
            
        }
        private void tbCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char is not CTRL or not number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string bank = tbBank.Text;
            int cardNumber = Convert.ToInt32(tbCardNum.Text);
            string cardType = cbType.Text.ToString();

            foreach (int seatNum in seat)
            {
                //Transfer data to Ticket database
                InsertTicket(seatNum, TotalPrice(idTrip), idUser, idTrip);

                //Add to list ticket
                tickets.Add(LoadTicket(GetIDTicket()));

                //Transfer data to Payment database
                InsertPayment(name, bank, cardNumber, cardType, GetIDTicket());

                //Update available seat in trip database
                UpdateSeat(idTrip);
            }

            MessageBox.Show("Payment Successfull!!");
            fTicketUser fTicketUser = new fTicketUser(seat.Count,idTrip,idUser,tickets);
            this.Hide();
            fTicketUser.ShowDialog();
            this.Show();

        }

        //Load Price
        void LoadPrice (float totalprice)
        {
            CultureInfo culture = new CultureInfo("en-GB");
            tbPrice.Text = totalprice.ToString("c",culture);
        }

        //Insert Ticket
        void InsertTicket (int seatNumber, float totalPrice, string idUser, string idTrip)
        {
            TicketDAO.Instance.InsertTicket(seatNumber, totalPrice, idUser, idTrip);
        }

        //Get TotalPrice of trip
        float TotalPrice (string idTrip)
        {
            return TicketDAO.Instance.TotalPrice(idTrip);
        }

        //Insert Payment
        void InsertPayment(string name, string bank, int cardNumber, string cardType, string idTicket)
        {
            PaymentDAO.Instance.InsertPayment(name, bank, cardNumber, cardType, idTicket);
        }

        //Get ID Ticket
        string GetIDTicket()
        {
            DataTable result = PaymentDAO.Instance.GetIDTicket();
            return result.Rows[0].ItemArray[0].ToString();
        }

        //UpdateSeat
        void UpdateSeat (string idTrip)
        {
            PaymentDAO.Instance.UpdateSeat(idTrip);
        }
        
        //Load Ticket
        Ticket LoadTicket (string idTicket)
        {
            return new Ticket (PaymentDAO.Instance.LoadTicket(idTicket).Rows[0]);
        }
    }
}
