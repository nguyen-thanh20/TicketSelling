using System.Windows.Forms;

namespace TicketSelling
{
    static class Program
    {
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
            //Application.Run(new ManagerForm("UID00000003"));
            //Application.Run(new fBill());
        }
    }
}
