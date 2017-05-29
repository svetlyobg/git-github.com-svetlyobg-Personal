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
    public partial class frmGrafichniFormati : Form
    {
        Thread th;
        public frmGrafichniFormati()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void btnRasterni_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goRasterni);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goRasterni(object obj)
        {
            Application.Run(new frmRastFormati());
        }

        private void btnVektorni_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(goVektorni);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goVektorni(object obj)
        {
            Application.Run(new frmVektFormati());
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goWebFormati);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goWebFormati(object obj)
        {
            Application.Run(new frmWebFormats());
        }
    }
}
