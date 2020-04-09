using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string writePath = @"C:\Users\semak\Desktop\hta.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Логин-{textBox1.Text}");
                    sw.WriteLine($"Пароль-{textBox2.Text}");
                    sw.WriteLine($"E-Mail-{textBox3.Text}");
                    sw.WriteLine($"Имя-{textBox4.Text}");
                    sw.WriteLine($"Номер телефона-{textBox5.Text}");
                    sw.WriteLine();
                    MessageBox.Show("Регистрация выполнена ");
                }

            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }

        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        } 
    }
}
