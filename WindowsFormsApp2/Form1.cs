using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (listBox1.Items.Count == 16)
            {
                label10.Text = "В игре максимальное количество игроков!";
                label10.ForeColor = Color.Red;
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == textBox1.Text) a++;
                }
                if (a > 0)
                {
                    label10.Text = "Этот игрок уже в игре!";
                    label10.ForeColor = Color.Red;
                }
                else
                {
                    listBox1.Items.Insert(listBox1.Items.Count, textBox1.Text);
                    label10.Text = "Игрок успешно добавлен!";
                    label10.ForeColor = Color.Black;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                label10.Text = "Выберите игрока для определения роли!";
                label10.ForeColor = Color.Red;
            }
            else
            {
                if (r1.Checked == false & r2.Checked == false & r3.Checked == false & r4.Checked == false & r5.Checked == false & r6.Checked == false & r7.Checked == false & r8.Checked == false)
                {
                    label10.Text = "Выберите роль для определения!";
                    label10.ForeColor = Color.Red;
                }
                else
                {
                    if (r1.Checked == true)
                    {
                        label2.Text = listBox1.SelectedItem.ToString();
                        if (label3.Text == label2.Text) label3.Text = "";
                        if (label4.Text == label2.Text) label4.Text = "";
                        if (label5.Text == label2.Text) label5.Text = "";
                        if (label6.Text == label2.Text) label6.Text = "";
                        if (label7.Text == label2.Text) label7.Text = "";
                        if (label8.Text == label2.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label2.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r2.Checked == true)
                    {
                        label3.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label3.Text) label2.Text = "";
                        if (label4.Text == label3.Text) label4.Text = "";
                        if (label5.Text == label3.Text) label5.Text = "";
                        if (label6.Text == label3.Text) label6.Text = "";
                        if (label7.Text == label3.Text) label7.Text = "";
                        if (label8.Text == label3.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label3.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r3.Checked == true)
                    {
                        label4.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label4.Text) label2.Text = "";
                        if (label3.Text == label4.Text) label3.Text = "";
                        if (label5.Text == label4.Text) label5.Text = "";
                        if (label6.Text == label4.Text) label6.Text = "";
                        if (label7.Text == label4.Text) label7.Text = "";
                        if (label8.Text == label4.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label4.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r4.Checked == true)
                    {
                        label5.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label5.Text) label2.Text = "";
                        if (label3.Text == label5.Text) label3.Text = "";
                        if (label4.Text == label5.Text) label4.Text = "";
                        if (label6.Text == label5.Text) label6.Text = "";
                        if (label7.Text == label5.Text) label7.Text = "";
                        if (label8.Text == label5.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label5.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r5.Checked == true)
                    {
                        label6.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label6.Text) label2.Text = "";
                        if (label3.Text == label6.Text) label3.Text = "";
                        if (label4.Text == label6.Text) label4.Text = "";
                        if (label5.Text == label6.Text) label5.Text = "";
                        if (label7.Text == label6.Text) label7.Text = "";
                        if (label8.Text == label6.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label6.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r6.Checked == true)
                    {
                        label7.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label7.Text) label2.Text = "";
                        if (label3.Text == label7.Text) label3.Text = "";
                        if (label4.Text == label7.Text) label4.Text = "";
                        if (label5.Text == label7.Text) label5.Text = "";
                        if (label6.Text == label7.Text) label6.Text = "";
                        if (label8.Text == label7.Text) label8.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label7.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r7.Checked == true)
                    {
                        label8.Text = listBox1.SelectedItem.ToString();
                        if (label2.Text == label8.Text) label2.Text = "";
                        if (label3.Text == label8.Text) label3.Text = "";
                        if (label4.Text == label8.Text) label4.Text = "";
                        if (label5.Text == label8.Text) label5.Text = "";
                        if (label7.Text == label8.Text) label7.Text = "";
                        if (label1.Text == label8.Text) label1.Text = "";
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == label8.Text) comboBox1.Items.RemoveAt(i);
                        }
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                    if (r8.Checked == true)
                    {
                        string a = listBox1.SelectedItem.ToString();
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == a) comboBox1.Items.RemoveAt(i);
                        }
                        comboBox1.Items.Insert(comboBox1.Items.Count, a);
                        if (label2.Text == a) label2.Text = "";
                        if (label3.Text == a) label3.Text = "";
                        if (label4.Text == a) label4.Text = "";
                        if (label5.Text == a) label5.Text = "";
                        if (label7.Text == a) label7.Text = "";
                        if (label1.Text == a) label1.Text = "";
                        if (label8.Text == a) label8.Text = "";
                        label10.Text = "Роль успешно определена!";
                        label10.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                label10.Text = "Выберите игрока для определения роли!";
                label10.ForeColor = Color.Red;
            }
            else
            {
                int a = rnd.Next(15);
                if (a==0)
                {
                    label2.Text = listBox1.SelectedItem.ToString();
                    if (label3.Text == label2.Text) label3.Text = "";
                    if (label4.Text == label2.Text) label4.Text = "";
                    if (label5.Text == label2.Text) label5.Text = "";
                    if (label6.Text == label2.Text) label6.Text = "";
                    if (label7.Text == label2.Text) label7.Text = "";
                    if (label8.Text == label2.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label2.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==1)
                {
                    label3.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label3.Text) label2.Text = "";
                    if (label4.Text == label3.Text) label4.Text = "";
                    if (label5.Text == label3.Text) label5.Text = "";
                    if (label6.Text == label3.Text) label6.Text = "";
                    if (label7.Text == label3.Text) label7.Text = "";
                    if (label8.Text == label3.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label3.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==2)
                {
                    label4.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label4.Text) label2.Text = "";
                    if (label3.Text == label4.Text) label3.Text = "";
                    if (label5.Text == label4.Text) label5.Text = "";
                    if (label6.Text == label4.Text) label6.Text = "";
                    if (label7.Text == label4.Text) label7.Text = "";
                    if (label8.Text == label4.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label4.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==3)
                {
                    label5.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label5.Text) label2.Text = "";
                    if (label3.Text == label5.Text) label3.Text = "";
                    if (label4.Text == label5.Text) label4.Text = "";
                    if (label6.Text == label5.Text) label6.Text = "";
                    if (label7.Text == label5.Text) label7.Text = "";
                    if (label8.Text == label5.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label5.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==4)
                {
                    label6.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label6.Text) label2.Text = "";
                    if (label3.Text == label6.Text) label3.Text = "";
                    if (label4.Text == label6.Text) label4.Text = "";
                    if (label5.Text == label6.Text) label5.Text = "";
                    if (label7.Text == label6.Text) label7.Text = "";
                    if (label8.Text == label6.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label6.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==5)
                {
                    label7.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label7.Text) label2.Text = "";
                    if (label3.Text == label7.Text) label3.Text = "";
                    if (label4.Text == label7.Text) label4.Text = "";
                    if (label5.Text == label7.Text) label5.Text = "";
                    if (label6.Text == label7.Text) label6.Text = "";
                    if (label8.Text == label7.Text) label8.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label7.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a ==6)
                {
                    label8.Text = listBox1.SelectedItem.ToString();
                    if (label2.Text == label8.Text) label2.Text = "";
                    if (label3.Text == label8.Text) label3.Text = "";
                    if (label4.Text == label8.Text) label4.Text = "";
                    if (label5.Text == label8.Text) label5.Text = "";
                    if (label7.Text == label8.Text) label7.Text = "";
                    if (label1.Text == label8.Text) label1.Text = "";
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == label8.Text) comboBox1.Items.RemoveAt(i);
                    }
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
                if (a >=7)
                {
                    string b = listBox1.SelectedItem.ToString();
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == b) comboBox1.Items.RemoveAt(i);
                    }
                    comboBox1.Items.Insert(comboBox1.Items.Count, b);
                    if (label2.Text == b) label2.Text = "";
                    if (label3.Text == b) label3.Text = "";
                    if (label4.Text == b) label4.Text = "";
                    if (label5.Text == b) label5.Text = "";
                    if (label7.Text == b) label7.Text = "";
                    if (label1.Text == b) label1.Text = "";
                    if (label8.Text == b) label8.Text = "";
                    label10.Text = "Роль успешно определена!";
                    label10.ForeColor = Color.Black;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 16)
            {
                label10.Text = "В игре не достаточно игроков!";
                label10.ForeColor = Color.Red;
            }
            else
            {
                comboBox1.Items.Clear();
                const int SIZE = 16;
                int[] chisla = new int[SIZE];
                Random r = new Random();
                int i = 0;
                while (i < SIZE)
                {
                    int temp = r.Next(SIZE);
                    if (chisla[temp] == 0)
                    {
                        chisla[temp] = i;
                        ++i;
                    }
                }
                label2.Text = listBox1.Items[chisla[0]].ToString();
                label8.Text = listBox1.Items[chisla[1]].ToString();
                label3.Text = listBox1.Items[chisla[2]].ToString();
                label4.Text = listBox1.Items[chisla[3]].ToString();
                label5.Text = listBox1.Items[chisla[4]].ToString();
                label6.Text = listBox1.Items[chisla[5]].ToString();
                label7.Text = listBox1.Items[chisla[6]].ToString();
                comboBox1.Items.Insert(0, listBox1.Items[chisla[7]].ToString());
                comboBox1.Items.Insert(1, listBox1.Items[chisla[8]].ToString());
                comboBox1.Items.Insert(2, listBox1.Items[chisla[9]].ToString());
                comboBox1.Items.Insert(3, listBox1.Items[chisla[10]].ToString());
                comboBox1.Items.Insert(4, listBox1.Items[chisla[11]].ToString());
                comboBox1.Items.Insert(5, listBox1.Items[chisla[12]].ToString());
                comboBox1.Items.Insert(6, listBox1.Items[chisla[13]].ToString());
                comboBox1.Items.Insert(7, listBox1.Items[chisla[14]].ToString());
                comboBox1.Items.Insert(8, listBox1.Items[chisla[15]].ToString());
                label10.Text = "Роли успешно определены!";
                label10.ForeColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            label2.Text = "";
            label8.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }
    }
}
