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
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformGraphics);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewformGraphics(object obj)
        {
            Application.Run(new Form3ComputerGraphics());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openKomputernaAnimacia);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openKomputernaAnimacia (object obj)
        {
            Application.Run(new FormKomputernaAnimacia());
        }

        private void btnMorphing_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMorphing);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openMorphing(object obj)
        {
            Application.Run(new frmMorphing());
        }

        private void btnCompression_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCompression);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openCompression(object obj)
        {
            Application.Run(new frmCompression());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormati);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openFormati(object obj)
        {
            Application.Run(new frmGrafichniFormati());
        }
    }
}
