using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace ClientGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            PipeClient p1 = new PipeClient();
            List<string> received1 = new List<string>();
            received1 = p1.GetInfoFromPipe("pipe1");
            for (int i = 0; i < received1.Count; i++)
            {
                lbx_message.Items.Add(received1[i]);
            }
        }
        private void btnCreateConnection2_Click(object sender, EventArgs e)
        {
            PipeClient p2 = new PipeClient();
            List<string> received2 = new List<string>();
            received2 = p2.GetInfoFromPipe("pipe2");
            for (int i = 0; i < received2.Count; i++)
            {
                lbx_message.Items.Add(received2[i]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbx_message.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
