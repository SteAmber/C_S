using System;
using System.Windows.Forms;

namespace ServerGUI
{
    public partial class sServer : Form
    {
        PipeServer1 server;

        public sServer()
        {
            InitializeComponent();
            server = new PipeServer1();
            server.Start();
        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

    }
}
