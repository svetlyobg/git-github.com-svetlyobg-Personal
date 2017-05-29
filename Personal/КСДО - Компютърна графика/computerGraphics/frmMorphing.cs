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
    public partial class frmMorphing : Form
    {
        Thread th;
        
        public frmMorphing()
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMorphing_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }
    }
}
