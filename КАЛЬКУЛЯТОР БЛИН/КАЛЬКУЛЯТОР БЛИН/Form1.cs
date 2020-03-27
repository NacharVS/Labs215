using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КАЛЬКУЛЯТОР_БЛИН
{
    public partial class Калькулятор : Form
    {
        int buf;
        string zapominalka;
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "4";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
                
            label1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            buf = int.Parse(label1.Text);
            label1.Text = "0";
            zapominalka = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (zapominalka)
            {
                case "/":
                    {
                        buf = buf / int.Parse(label1.Text);
                        label1.Text = buf.ToString();
                    }
                    break;
                case "*":
                    {
                        buf = buf * int.Parse(label1.Text);
                        label1.Text = buf.ToString();
                    }
                    break;
                case "+":
                    {
                        buf = buf + int.Parse(label1.Text);
                        label1.Text = buf.ToString();
                    }
                    break;
                case "-":
                    {
                        buf = buf - int.Parse(label1.Text);
                        label1.Text = buf.ToString();
                    }
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buf = int.Parse(label1.Text);
            label1.Text = "0";
            zapominalka = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buf = int.Parse(label1.Text);
            label1.Text = "0";
            zapominalka = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buf = int.Parse(label1.Text);
            label1.Text = "0";
            zapominalka = "-";
        }
    }
}
