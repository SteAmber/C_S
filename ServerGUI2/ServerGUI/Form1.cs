using System;
using System.Windows.Forms;

namespace ServerGUI
{
    public partial class Form1 : Form
    {
        PipeServer2 server;
        public Form1()
        {
            InitializeComponent();
            server = new PipeServer2();
            server.Start();
        }
        private void btn_ClearInformation_Click(object sender, EventArgs e)
        {
            lbx_clientList.Items.Clear();
        }
        private void Form1_Closed(object sender, System.EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
