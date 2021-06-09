using System;
using System.Windows.Forms;
using System.Threading;

namespace ClientGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool onlyInstance;
            Mutex mtx = new Mutex(true, "PC", out onlyInstance);
            if (onlyInstance)
            Application.Run(new Form1());
            else
            MessageBox.Show("Приложение уже запущено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
