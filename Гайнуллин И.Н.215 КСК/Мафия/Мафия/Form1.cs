using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;


namespace Мафия
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naruto = textBox1.Text;
            if (naruto == "")
                MessageBox.Show("Поле не может быть пустым");
            else
            {
                if (listBox1.Items.Count >= 16)
                {
                    MessageBox.Show("Достигнуто максимальное кол-во игркоков");
                }
                else
                {
                    if (listBox1.Items.Contains(naruto))
                    {
                        MessageBox.Show("Игрок с таким именем уже существует");
                    }
                    else
                    {
                        listBox1.Items.Add(naruto);
                        textBox1.Clear();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите игрока");
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    MessageBox.Show("Выберите роль");
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        if (label7.Text == "")
                        {
                            label7.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (label8.Text == "")
                        {
                            label8.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (label9.Text == "")
                        {
                            label9.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton4.Checked == true)
                    {
                        if (label9.Text == "")
                        {
                            label9.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton5.Checked == true)
                    {
                        if (comboBox1.Text == "")
                        {
                            comboBox1.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!(listBox1.Items.Count < 11))
            {
                Random rnd = new Random();
                int[] rndmass = new int[listBox1.Items.Count];
                for (int i = 0; i < rndmass.Length - 1; i++)
                {
                    int x = rnd.Next(0, listBox1.Items.Count);

                    if (!(rndmass.Contains(x)))
                        rndmass[i] = x;
                    else i--;

                }
                comboBox1.Items.Add(listBox1.Items[rndmass[0]].ToString());
                comboBox1.Items.Add(listBox1.Items[rndmass[1]].ToString());
                label7.Text = listBox1.Items[rndmass[2]].ToString();
                label8.Text = listBox1.Items[rndmass[3]].ToString();
                label9.Text = listBox1.Items[rndmass[4]].ToString();
                label10.Text = listBox1.Items[rndmass[5]].ToString();

                for (int i = 6; i < listBox1.Items.Count; i++)
                {
                    comboBox1.Items.Add(listBox1.Items[rndmass[i]]).ToString();
                }

            }
            else MessageBox.Show("Пользователей менее 11");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }
    }
}
