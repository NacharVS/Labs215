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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SmallImageList = imageList1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = 0; // установка картинки для файла
                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }
        }
    }
}
