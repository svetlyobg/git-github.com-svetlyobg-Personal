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
    public partial class Form4VidoveGrafika : Form
    {
        Thread th;
        public Form4VidoveGrafika()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtoform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backtoform3(object obj)
        {
            Application.Run(new Form3ComputerGraphics());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(FormRasternaGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void FormRasternaGrafika(object obj)
        {
            Application.Run(new FormRasternaGrafika());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(FormVektornaGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void FormVektornaGrafika(object obj)
        {
            Application.Run(new FormVektornaGrafika());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Form2D);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Form2D(object obj)
        {
            Application.Run(new Form2D());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Form3D);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();            
        }
        private void Form3D(object obj)
        {
            Application.Run(new Form3D());
        }
    }
}
