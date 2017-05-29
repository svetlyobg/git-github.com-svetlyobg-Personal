using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Video 1 https://www.youtube.com/watch?v=Is1EHXFhEe4
/// Video 2 https://www.youtube.com/watch?v=o2EVSqquqzc
/// </summary>
namespace Calculator
{
    public partial class Елка : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Елка()
        {
            InitializeComponent();
        }

        private void Елка_Load(object sender, EventArgs e)
        {

        }

        private void ce_click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
        }

        private void buttonNumber_click(object sender, EventArgs e)
        {
            if ((textBox1_result.Text == "0") || (operation_pressed))
            {
                textBox1_result.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!textBox1_result.Text.Contains("."))
                {
                    textBox1_result.Text = textBox1_result.Text + b.Text;
                }
            }
            else
                textBox1_result.Text = textBox1_result.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                if (b.Text == "sqrt")
                    textBox1_result.Text = Math.Sqrt(Double.Parse(textBox1_result.Text)).ToString();
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else if (b.Text == "sqrt")
            {
                textBox1_result.Text = Math.Sqrt(Double.Parse(textBox1_result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(textBox1_result.Text));
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(textBox1_result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1_result.Text = (value + Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "-":
                    textBox1_result.Text = (value - Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "*":
                    textBox1_result.Text = (value * Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "/":
                    textBox1_result.Text = (value / Double.Parse(textBox1_result.Text)).ToString();
                    break;
                //case "\r":
                //    equal.PerformClick();
                //    break;
                default:
                    break;
            }
            value = Double.Parse(textBox1_result.Text);
            operation = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Елка_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}