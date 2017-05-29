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
    public partial class Kluchovikadri : Form
    {
        Thread th;
        public Kluchovikadri()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(close);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void close(object obj)
        {
            Application.Run(new FormKomputernaAnimacia());
        }
    }
}
