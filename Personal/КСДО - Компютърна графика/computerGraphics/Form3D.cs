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
    public partial class Form3D : Form
    {
        Thread th;
        public Form3D()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtoForm4VidoveGrafika);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backtoForm4VidoveGrafika(object obj)
        {
            Application.Run(new Form4VidoveGrafika());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goToFormRendirane);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goToFormRendirane(object obj)
        {
            Application.Run(new FormRendirane());
        }
    }
}
