using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ServerGUI
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
            Mutex mtx = new Mutex(true, "PC2", out onlyInstance);
            if(onlyInstance)
            Application.Run(new Form1());
            else
                MessageBox.Show("Приложение уже запущено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
