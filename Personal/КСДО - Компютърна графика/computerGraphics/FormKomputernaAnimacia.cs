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
    public partial class FormKomputernaAnimacia : Form
    {
        Thread th;
        public FormKomputernaAnimacia()
        {
            InitializeComponent();
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
            Application.Run(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goSkeletna);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goSkeletna(object obj)
        {
            Application.Run(new SkeletnaAnimacia());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goMaketi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goMaketi(object obj)
        {
            Application.Run(new Maketi());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goPokadrova);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goPokadrova (object obj)
        {
            Application.Run(new Pokadrova());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goProcedurna);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goProcedurna(object obj)
        {
            Application.Run(new Procedurna());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goGIF);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goGIF(object obj)
        {
            Application.Run(new GIF());
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openKluchovikadri);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openKluchovikadri(object obj)
        {
            Application.Run(new Kluchovikadri());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMotionCapture);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openMotionCapture(object obj)
        {
            Application.Run(new MotionCapture());
        }

        private void FormKomputernaAnimacia_Load(object sender, EventArgs e)
        {

        }
    }
}
