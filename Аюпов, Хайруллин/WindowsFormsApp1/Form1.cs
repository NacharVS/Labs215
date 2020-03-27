using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double buf;
        string buff;
        bool stat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Text = "";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            button2.Text += button3.Text;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            button2.Text += button4.Text;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            button2.Text += button5.Text;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            button2.Text += button6.Text;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            button2.Text += button7.Text;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            button2.Text += button8.Text;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            button2.Text += button9.Text;
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            button2.Text += button10.Text;
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            button2.Text += button11.Text;
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            button2.Text += button17.Text;
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }
        private void Button12_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = "";
            buff = "+";
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = "";
            buff = "-";
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = "";
            buff = "x";
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = "";
            buff = ":";
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = $"{Math.Sqrt(buf)}";
            buff = "";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = $"{buf * buf}";
            buff = "";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            buf = double.Parse(button2.Text);
            button2.Text = "";
            buff = "^y";
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            if (buff == "+")
            {
                button2.Text = $"{buf + double.Parse(button2.Text)}";
                buff = "";
            }
            if (buff == "-")
            {
                button2.Text = $"{buf - double.Parse(button2.Text)}";
                buff = "";
            }
            if (buff == "x")
            {
                button2.Text = $"{buf * double.Parse(button2.Text)}";
                buff = "";
            }
            if (buff == ":")
            {
                button2.Text = $"{buf / double.Parse(button2.Text)}";
                buff = "";
            }
            if (buff == "^y")
            {
                button2.Text = $"{Math.Pow(buf, double.Parse(button2.Text))}";
                buff = "";
            }
        }
    }
}
