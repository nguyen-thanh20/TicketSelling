using System.Windows.Forms;
using System;

namespace TicketSelling
{
    static class Program
    {
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
            //Application.Run(new fQuerry());
            //Application.Run(new fChangePassword("UID00000001"));
        }
    }
}
