using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мафия
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)//добавить
        {
            listBox1.Items.Insert(listBox1.Items.Count, textBox1.Text);
            if (listBox1.Items.Count > 16)
            {

                textBox1.Text = "Ошибка";
                listBox1.Items.RemoveAt(16);
            }

        }
        private void button4_Click(object sender, EventArgs e)//удалить
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//Listbox
        {
           
        }
        private void button1_Click(object sender, EventArgs e)//назначить
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    textBox2.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    textBox3.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    textBox4.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton4.Checked == true)
                {
                    textBox5.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton5.Checked == true)
                {
                    textBox6.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton6.Checked == true)
                {
                    textBox7.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton7.Checked == true)
                {
                    textBox8.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton8.Checked == true)
                {
                    textBox9.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton9.Checked == true)
                {
                    textBox10.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton10.Checked == true)
                {
                    textBox11.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton11.Checked == true)
                {
                    textBox12.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton12.Checked == true)
                {
                    textBox13.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton13.Checked == true)
                {
                    textBox14.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton14.Checked == true)
                {
                    textBox15.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton15.Checked == true)
                {
                    textBox16.Text = listBox1.SelectedItem.ToString();
                }
                if (radioButton16.Checked == true)
                {
                    textBox17.Text = listBox1.SelectedItem.ToString();
                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
       
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            //int[] mass = new int[16];

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    mass[i] = rnd.Next(listBox1.Items.Count);//Это и есть индекс
            //    textBox1.Text = mass[i].ToString();

            //}

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    textBox2.Text = listBox1.Items[mass[i]].ToString();
            //    textBox3.Text = listBox1.Items[mass[i]].ToString();
            //    textBox4.Text = listBox1.Items[mass[i]].ToString();
            //}
           
                textBox2.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox3.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox4.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox5.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox6.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox7.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox8.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox9.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox10.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox11.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox12.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox13.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox14.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox15.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox16.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
                textBox17.Text = listBox1.Items[random.Next(listBox1.Items.Count)].ToString();
            
        }
    }
}
