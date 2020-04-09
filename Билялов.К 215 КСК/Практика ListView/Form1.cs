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

namespace tetswinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SmallImageList = imageList1;
          
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            try
            {
                string[] files = Directory.GetFiles(path);
            
                foreach (string file in files)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                    lvi.ImageIndex = 0;
                    listView1.Items.Add(lvi);
                }
            }
            catch { MessageBox.Show("Введен некорректный путь"); }
        }
    }
    
}
