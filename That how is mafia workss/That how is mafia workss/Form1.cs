using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace That_how_is_mafia_workss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string Makarona = textBox1.Text;
            if (Makarona == "")
                MessageBox.Show("Поле не может быть пустым");
            else
            {
                if (listBox1.Items.Count >= 8)
                {
                    MessageBox.Show("Достигнуто максимальное кол-во игроков");
                }
                else
                {
                    if (listBox1.Items.Contains(Makarona))
                    {
                        MessageBox.Show("Игрок с таким именем уже существует");
                    }
                    else
                    {
                        listBox1.Items.Add(Makarona);
                        textBox1.Clear();
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DELETE = (textBox1.Text);
            if (listBox1.Items.Contains(DELETE))
            {
                listBox1.Items.Remove(DELETE);
            }
            else
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Введите или выберите имя игрока");
                }
                else listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите игрока");
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("Выберите роль");
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        if (listBox2.Items.Count < 1)
                        {
                            listBox2.Items.Add(listBox1.SelectedItem);
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Максимальное кол-во игроков, играющих за мафию");
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (listBox3.Items.Count < 1)
                        {
                            listBox3.Items.Add(listBox1.SelectedItem);
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Максимальное кол-во игроков, играющих за комиссара");
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (listBox4.Items.Count < 1)
                        {
                            listBox4.Items.Add(listBox1.SelectedItem);
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Максимальное кол-во игроков, играющих за доктора");
                    }
                    if (radioButton4.Checked == true)
                    {
                        if (listBox5.Items.Count < 5)
                        {
                            listBox5.Items.Add(listBox1.SelectedItem);
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Максимальное кол-во игроков, играющих за жителей");
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            MessageBox.Show("Игра успешно сброшена");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 8)
            {
                int rnd = 0;
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    rnd = rand.Next(0, 8 - i);
                    listBox5.Items.Add(listBox1.Items[rnd]);
                    listBox1.Items.Remove(listBox1.Items[rnd]);
                }
                
                rnd = rand.Next(0, 3);
                listBox3.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);
                rnd = rand.Next(0, 2);
                listBox4.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);
                rnd = rand.Next(0, 1);
                listBox2.Items.Add(listBox1.Items[rnd]);
                listBox1.Items.Remove(listBox1.Items[rnd]);


            }
            else { MessageBox.Show("Игроков должно быть 14"); }
        }
    }
}
