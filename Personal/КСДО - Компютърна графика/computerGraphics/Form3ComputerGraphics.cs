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
    public partial class Form3ComputerGraphics : Form
    {
        Thread th;
        public Form3ComputerGraphics()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtoform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backtoform2(object obj)
        {
            Application.Run(new Form2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openForm4VidoveGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openForm4VidoveGrafika(object obj)
        {
            Application.Run(new Form4VidoveGrafika());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSintezAnaliz);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openSintezAnaliz(object obj)
        {
            Application.Run(new FormSintezAnaliz());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openInformatika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openInformatika(object obj)
        {
            Application.Run(new FormInformatika());
        }
    }
}
