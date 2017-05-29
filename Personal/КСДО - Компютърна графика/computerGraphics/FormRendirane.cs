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
    public partial class FormRendirane : Form
    {
        Thread th;
        public FormRendirane()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backToForm3D);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backToForm3D(object obj)
        {
            Application.Run(new Form3D());
        }
    }
}
