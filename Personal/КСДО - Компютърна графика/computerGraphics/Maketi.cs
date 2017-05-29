﻿using System;
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
    public partial class Maketi : Form
    {
        Thread th;
        public Maketi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void back (object obj)
        {
            Application.Run(new FormKomputernaAnimacia());
        }
    }
}
