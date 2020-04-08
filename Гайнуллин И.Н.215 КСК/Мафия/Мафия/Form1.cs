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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = textBox1.Text;
            if (ss == "")
                MessageBox.Show("Поле не может быть пустым");
            else
            {
                if (listBox1.Items.Count >= 16)
                {
                    MessageBox.Show("Достигнуто максимальное кол-во игркоков");
                }
                else
                {
                    if (listBox1.Items.Contains(ss))
                    {
                        MessageBox.Show("Игрок с таким именем уже существует");
                    }
                    else
                    {
                        listBox1.Items.Add(ss);
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
                        if (label3.Text == "")
                        {
                            label3.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (label4.Text == "")
                        {
                            label4.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (label5.Text == "")
                        {
                            label5.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton4.Checked == true)
                    {
                        if (label6.Text == "")
                        {
                            label6.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Игрок уже назначен");
                    }
                    if (radioButton5.Checked == true)
                    {
                        if (listBox2.Items.Count < 9)
                        {
                            listBox2.Items.Add(listBox1.SelectedItem.ToString());
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        }
                        else MessageBox.Show("Максимальное кол-во мирных жителей");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
                listBox1.Items.Add(label3.Text);
            label3.Text = "";
            if (label4.Text != "")
                listBox1.Items.Add(label4.Text);
            label4.Text = "";
            if (label5.Text != "")
                listBox1.Items.Add(label5.Text);
            label5.Text = "";
            if (label6.Text != "")
                listBox1.Items.Add(label6.Text);
            label6.Text = "";
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }
    }
}
