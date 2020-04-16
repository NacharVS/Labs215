using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Мафиозник
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            if (Name == "")
            {
                MessageBox.Show("Введите имя");
            }
            else
            {
                if(listBox1.Items.Count >= 14)
                {
                    MessageBox.Show("Максимальное количество игроков");
                }
                else
                {
                    if (listBox1.Items.Contains(Name))
                    {
                        MessageBox.Show("Игрок с таким именем уже существует");
                    }
                    else
                    {
                        listBox1.Items.Add(Name);
                        textBox1.Clear();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (listBox2.Items.Count < 2)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Максимальное количество игроков не более 2 человек");
            }
            if(radioButton2.Checked == true)
            {
                if (listBox3.Items.Count < 1)
                {
                    listBox3.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Максимальное количество игроков не более 1 человека");
                
            }
            if (radioButton3.Checked == true)
            {
                if(listBox4.Items.Count < 1)
                {
                    listBox4.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Максимальное количество игроков не более 1 человека");
            }
            if (radioButton4.Checked == true)
            {
                if (listBox5.Items.Count < 1)
                {
                    listBox5.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Максимальное количество игроков не более 1 человека");
            }
            if (radioButton5.Checked == true)
            {
                if (listBox6.Items.Count < 9)
                {
                    listBox6.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Максимальное количество игроков не более 9 человек");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 14)
            {
                int rnd = 0;
                Random rand = new Random();
                for (int i = 0; i < 2; i++)
                {
                    rnd = rand.Next(0, 14 - i);
                    listBox2.Items.Add(listBox1.Items[rnd]);
                    listBox1.Items.Remove(listBox1.Items[rnd]);
                }
                for (int i = 0; i < 9; i++)
                {
                    rnd = rand.Next(0, 11 - i);
                    listBox6.Items.Add(listBox1.Items[rnd]);
                    listBox1.Items.Remove(listBox1.Items[rnd]);
                }
                rnd = rand.Next(0, 3);
                listBox3.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);
                rnd = rand.Next(0, 2);
                listBox4.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);
                rnd = rand.Next(0, 1);
                listBox5.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);
                
                
            }
            else { MessageBox.Show("Игроков должно быть 14"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }
    }
}
