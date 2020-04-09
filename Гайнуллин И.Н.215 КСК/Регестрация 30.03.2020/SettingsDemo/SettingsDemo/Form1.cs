using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsDemo
{
    public partial class Form1 : Form
    {
        Settings _settings = null;

        public Form1()
        {
            InitializeComponent();

            _settings = Settings.GetSettings();

            _initControlls();
        }


        private void _initControlls()
        {
            Login.Text = _settings.Login;
            EMAIL.Text = _settings.EMAIL;
            Password.Text = _settings.Pasword;
            Name.Text = _settings.Name;
            TelephoneNumber.Text = _settings.TelephoneNumber;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _settings.Login = Login.Text;
            _settings.EMAIL = EMAIL.Text;
            _settings.Pasword = Password.Text;
            _settings.Name = Name.Text;
            _settings.TelephoneNumber = TelephoneNumber.Text;

            _settings.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.Clear();
            Password.Clear();
            EMAIL.Clear();
            Name.Clear();
            TelephoneNumber.Clear();
        }

    }
}
