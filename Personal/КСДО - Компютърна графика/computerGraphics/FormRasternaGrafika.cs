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
    public partial class FormRasternaGrafika : Form
    {
        Thread th;
        public FormRasternaGrafika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backToVodoveGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backToVodoveGrafika(object obj)
        {
            Application.Run(new Form4VidoveGrafika());
        }

    }
}
