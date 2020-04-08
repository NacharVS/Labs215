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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string writePath = $@"C:\Users\Педагог\Desktop\{tLogin.Text}.txt";
            if (File.Exists(writePath) == false)
            {
                gLogin.ForeColor = Color.Black;
                if (tPass.Text.Length < 8)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Пароль слишком короткий!";
                    gPass.ForeColor = Color.Red;
                }
                else
                {
                    gPass.ForeColor = Color.Black;
                    int j = 0;
                    foreach (char i in tPass.Text)
                    {
                        if (i == '1' | i == '2' | i == '3' | i == '4' | i == '5' | i == '6' | i == '7' | i == '8' | i == '9' | i == '0') j++;
                    }
                    if (j == 0)
                    {
                        label1.ForeColor = Color.Red;
                        label1.Text = "Пароль должен содержать буквы и цифры!";
                        gPass.ForeColor = Color.Red;
                    }
                    else
                    {
                        gPass.ForeColor = Color.Black;
                        int o = 0;
                        for (int i= 0;i < tMail.Text.Length; i++)
                        {
                            if (tMail.Text[i] == '@') o++;
                        }
                        foreach (char i in tPass.Text)
                        {
                            if (i == '@') o++;
                        }
                        if (o == 0)
                        {
                            label1.ForeColor = Color.Red;
                            label1.Text = "E-Mail указан не верно!";
                            gMail.ForeColor = Color.Red;
                        }
                        else
                        {
                            gMail.ForeColor = Color.Black;
                            if (tPhone.Text[0] != '8' | tPhone.Text.Length != 11)
                            {
                                label1.ForeColor = Color.Red;
                                label1.Text = "Номер должен начинаться с '8' и состоять из 11 цифр!";
                                gPhone.ForeColor = Color.Red;
                            }
                            else
                            {
                                gPhone.ForeColor = Color.Black;
                                label1.ForeColor = Color.Black;
                                label1.Text = "Аккаунт успешно создан!";
                                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine($"Логин пользователя: {tLogin.Text}\nПароль: {tPass.Text}\nE-Mail: {tMail.Text}\nИмя: {tName.Text}\nНомер телефона: {tPhone.Text}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Аккаунт с таким логином уже существует!";
                gLogin.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            tLogin.Text = "";
            tPass.Text = "";
            tMail.Text = "";
            tName.Text = "";
            tPhone.Text = "";
            gLogin.ForeColor = Color.Black;
            gPass.ForeColor = Color.Black;
            gMail.ForeColor = Color.Black;
            gPhone.ForeColor = Color.Black;
            gName.ForeColor = Color.Black;
        }
    }
}
