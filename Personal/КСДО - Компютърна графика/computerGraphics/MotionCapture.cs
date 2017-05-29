using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace computerGraphics
{
    public partial class MotionCapture : Form
    {
        Thread th;
        public MotionCapture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Wu9XPEdBelY&feature=youtu.be");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goback);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goback(object obj)
        {
            Application.Run(new FormKomputernaAnimacia());
        }
    }
}
