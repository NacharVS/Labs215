using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WindowsFormsApp6
{

    public partial class Form1 : Form
    {
        public int o = 0;
        [BsonKnownTypes(typeof(RegUsers))]
        public class RegUsers
        {
            [BsonId]
            public int id;
            public string Date;
            public List<string> Users;
        }
        [BsonKnownTypes(typeof(Team))]
        public class Team
        {
            [BsonId]
            public int id;
            public string tmName;
            public List<string> Mafia;
            public string Boss;
            public string Sherif;
            public string Doctor;
            public string Maniac;
            public List<string> Citzen;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 10)
            {
                int j = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == textBox1.Text)
                    {
                        j++;
                    }
                }
                if (j == 0)
                    listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.Items.Count > 2) { }
                else
                {
                    for (int i = 0; i < comboBox3.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                    }
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                    }
                    if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                    if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                    if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                    if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                    comboBox1.Items.Insert(comboBox1.Items.Count, listBox1.SelectedItem.ToString());
                }
                
            }
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label8.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label9.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton4.Checked == true)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label10.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton5.Checked == true)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label11.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton6.Checked == true)
            {
                if (comboBox2.Items.Count > 2) { }
                else
                {
                    for (int i = 0; i < comboBox3.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                    }
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                    }
                    if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                    if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                    if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                    if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                    comboBox2.Items.Insert(comboBox2.Items.Count, listBox1.SelectedItem.ToString());
                }
            }
        }

        public async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<Team>("Teams");
            var collection1 = database.GetCollection<RegUsers>("Users");
            var filter = new BsonDocument();
            var filter1 = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();
            foreach (Team doc in people)
            {
                comboBox3.Items.Add(doc.tmName);
            }
            var people1 = await collection1.Find(filter1).ToListAsync();
            foreach (RegUsers doc in people1)
            {
                comboBox4.Items.Add(doc.Date);
            }
        }

        async private void button7_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < comboBox3.Items.Count;i++)
            {
                if (comboBox3.Items[i].ToString() == textBox2.Text)
                {
                    a++;
                }
            }
            if (a == 0)
            {
                Team tm1 = new Team();
                tm1.Mafia = new List<string>();
                tm1.Citzen = new List<string>();
                string connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("Mafia");
                var collection = database.GetCollection<Team>("Teams");
                tm1.id = o;
                tm1.tmName = textBox2.Text;
                tm1.Mafia.Add(comboBox1.Items[0].ToString());
                tm1.Mafia.Add(comboBox1.Items[1].ToString());
                tm1.Mafia.Add(comboBox1.Items[2].ToString());
                tm1.Boss = label8.Text;
                tm1.Sherif = label9.Text;
                tm1.Doctor = label10.Text;
                tm1.Maniac = label11.Text;
                tm1.Citzen.Add(comboBox1.Items[0].ToString());
                tm1.Citzen.Add(comboBox1.Items[1].ToString());
                tm1.Citzen.Add(comboBox1.Items[2].ToString());
                o++;
                try
                {
                    await collection.InsertOneAsync(tm1);
                }
                catch
                {
                    o++;
                    tm1.id = o;
                    o++;
                    await collection.InsertOneAsync(tm1);
                }
                comboBox3.Items.Insert(comboBox3.Items.Count,textBox2.Text);
                
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(9);
            if (a == 0)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox1.Items.Insert(comboBox1.Items.Count, listBox1.SelectedItem.ToString());
            }
            if (a == 1)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label8.Text = listBox1.SelectedItem.ToString();
            }
            if (a == 2)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label9.Text = listBox1.SelectedItem.ToString();
            }
            if (a == 3)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label10.Text = listBox1.SelectedItem.ToString();
            }
            if (a == 4)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                label11.Text = listBox1.SelectedItem.ToString();
            }
            if (a == 5)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox2.Items.Insert(comboBox2.Items.Count, listBox1.SelectedItem.ToString());
            }
            if (a == 6)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox1.Items.Insert(comboBox1.Items.Count, listBox1.SelectedItem.ToString());
            }
            if (a == 7)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox1.Items.Insert(comboBox1.Items.Count, listBox1.SelectedItem.ToString());
            }
            if (a == 8)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox2.Items.Insert(comboBox2.Items.Count, listBox1.SelectedItem.ToString());
            }
            if (a == 9)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox1.Items.Remove(comboBox3.Items[i]);
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == listBox1.SelectedItem.ToString()) comboBox2.Items.Remove(comboBox2.Items[i]);
                }
                if (label8.Text == listBox1.SelectedItem.ToString()) label8.Text = "";
                if (label9.Text == listBox1.SelectedItem.ToString()) label9.Text = "";
                if (label10.Text == listBox1.SelectedItem.ToString()) label10.Text = "";
                if (label11.Text == listBox1.SelectedItem.ToString()) label11.Text = "";
                comboBox2.Items.Insert(comboBox2.Items.Count, listBox1.SelectedItem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            const int SIZE = 10;
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
            comboBox1.Items.Insert(0,listBox1.Items[chisla[0]].ToString());
            comboBox1.Items.Insert(1, listBox1.Items[chisla[1]].ToString());
            comboBox1.Items.Insert(2, listBox1.Items[chisla[2]].ToString());
            label8.Text = listBox1.Items[chisla[3]].ToString();
            label9.Text = listBox1.Items[chisla[4]].ToString();
            label10.Text = listBox1.Items[chisla[5]].ToString();
            label11.Text = listBox1.Items[chisla[6]].ToString();
            comboBox2.Items.Insert(0, listBox1.Items[chisla[7]].ToString());
            comboBox2.Items.Insert(1, listBox1.Items[chisla[8]].ToString());
            comboBox2.Items.Insert(2, listBox1.Items[chisla[9]].ToString());
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<RegUsers>("Users");
            var filter = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();
            for(int i = 0; i < comboBox4.Items.Count;i++)
            {
                await collection.DeleteOneAsync(filter);
            }
            listBox1.Items.Clear();
            comboBox4.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Items.Clear();
            }
            if (radioButton2.Checked == true)
            {
                label8.Text = "";
            }
            if (radioButton3.Checked == true)
            {
                label9.Text = "";
            }
            if (radioButton4.Checked == true)
            {
                label10.Text = "";
            }
            if (radioButton5.Checked == true)
            {
                label11.Text = "";
            }
            if (radioButton6.Checked == true)
            {
                comboBox2.Items.Clear();
            }
        }

        async private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<Team>("Teams");
            var filter = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();

            foreach (Team doc in people)
            {
                if (doc.tmName == comboBox3.SelectedItem.ToString())
                {
                    comboBox1.Items.Insert(0,doc.Mafia[0]);
                    comboBox1.Items.Insert(1, doc.Mafia[1]);
                    comboBox1.Items.Insert(2, doc.Mafia[2]);
                    label8.Text = doc.Boss;
                    label9.Text = doc.Sherif;
                    label10.Text = doc.Doctor;
                    label11.Text = doc.Maniac;
                    comboBox2.Items.Insert(0, doc.Citzen[0]);
                    comboBox2.Items.Insert(1, doc.Citzen[1]);
                    comboBox2.Items.Insert(2, doc.Citzen[2]);
                }
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<RegUsers>("Users");
            RegUsers ru1 = new RegUsers();
            ru1.Date = $"Регистрация от {DateTime.Now}";
            ru1.Users = new List<string>();
            for(int i =0;i< listBox1.Items.Count; i++)
            {
                ru1.Users.Add(listBox1.Items[i].ToString());
            }
            ru1.id = o;
            o++;
            comboBox4.Items.Add(ru1.Date);
            try
            {
                await collection.InsertOneAsync(ru1);
            }
            catch
            {
                o++;
                ru1.id = o;
                o++;
                await collection.InsertOneAsync(ru1);
            }
            
        }

        private async void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<RegUsers>("Users");
            var filter = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();
            
            foreach (RegUsers doc in people)
            {
                if (doc.Date == comboBox4.SelectedItem.ToString())
                {
                    for (int i = 0; i < doc.Users.Count; i++)
                    {
                        listBox1.Items.Add(doc.Users[i]);
                    }
                }
                
            }
        }
    }
}