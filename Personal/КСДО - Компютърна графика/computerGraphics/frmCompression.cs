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
    public partial class frmCompression : Form
    {
        Thread th;
        public frmCompression()
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

        private void btnMethodsCompression_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMethods);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openMethods(object obj)
        {
            Application.Run(new frmCompressionMethod());
        }
    }
}
