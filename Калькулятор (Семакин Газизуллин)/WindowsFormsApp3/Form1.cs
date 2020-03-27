using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        float a, b;
        int count;
      

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }
        private void button15_Click(object sender, EventArgs e)//вывод
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
            
                

                default:
                    break;
            }



        }
        private void button12_Click(object sender, EventArgs e)//+
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            count = 1;
        }
        private void button17_Click(object sender, EventArgs e)//-
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
        }
        private void button14_Click(object sender, EventArgs e)//*
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
        }
        private void button13_Click(object sender, EventArgs e)//\
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
        }
        private void button11_Click(object sender, EventArgs e)//x*x
        {
            a = float.Parse(textBox1.Text);
            b = a * a;
            textBox1.Text = b.ToString();
            count = 5;
        }
        private void button18_Click(object sender, EventArgs e)//sqrt
        { 
            double d;
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(d));
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)//2
        {
                int c = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(c, 2); 
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)//8
        {
            int c = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(c, 8);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)//16
        {
            int c = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(c, 16);
        }
    }
}
