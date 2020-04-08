using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практическая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\user\Desktop\уч\RegData.txt";
            string login = $"{textBox1.Text}";
            string password = $"{textBox2.Text}";
            string email = $"{textBox3.Text}";
            string name = $"{textBox3.Text}";
            string telephone = $"{textBox3.Text}";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync($"Логин: {login}");
                    await sw.WriteLineAsync($"Пароль: {password}");
                    await sw.WriteLineAsync($"Почта: {email}");
                    await sw.WriteLineAsync($"Имя: {name}");
                    await sw.WriteLineAsync($"Телефон: {telephone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
