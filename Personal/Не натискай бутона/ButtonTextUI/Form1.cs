using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonTextUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText("Нали ти казах да не го натискашшш eeе! @@\r\n");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.DarkBlue;
            richTextBox1.AppendText("Не натискай бутона!!!\r\n");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.AppendText("А така, разкарай се :)\r\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
