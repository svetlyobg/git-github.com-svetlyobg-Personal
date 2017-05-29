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
    public partial class FormVektornaGrafika : Form
    {
        Thread th;
        public FormVektornaGrafika()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backToForm4VidoveGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backToForm4VidoveGrafika(object obj)
        {
            Application.Run(new Form4VidoveGrafika());
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FormVektornaGrafika_Load(object sender, EventArgs e)
        {

        }
    }
}
