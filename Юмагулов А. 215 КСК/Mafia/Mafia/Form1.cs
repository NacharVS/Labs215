using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Mafia
{
    public partial class Form1 : Form
    {

        [BsonKnownTypes(typeof(Team))]
        class Team
        {
            [BsonId]
            public string TM_name;
            public List<string> mafia_role = new List<string>();
            public string butter_role;
            public string sherif_role;
            public string doc_role;
            public List<string> civilian_role = new List<string>();         
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {   
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text))
            {

                errorProvider1.SetError(name, "Пустой ник (имя) не может быть !");

            }
            else if (listBox1.Items.Count == 16)
            {
                errorProvider1.SetError(name, "В списке 16 человек!\nМаксимум :(");
            }
            else
            {
                    errorProvider1.Clear();
                    listBox1.Items.Add(name.Text);
                    name.Text = "";
                panel1.Visible = true;
                button1.Visible = true;
                Cle.Visible = true;
            }
          
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int v = int.Parse(listBox1.SelectedIndex.ToString());
            if (v >= 0)
            {
                del.Text = listBox1.SelectedItem.ToString();
            }
            if (String.IsNullOrEmpty(del.Text))
            {

                errorProvider2.SetError(del, "Пустой ник (имя) не может быть !");

            }
            else
            {
                errorProvider2.Clear();
                bool g = listBox1.Items.Contains(del.Text);
                if (g == true)
                {
                    MessageBox.Show($"_Удален игрок_ {del.Text}");
                    listBox1.Items.Remove(del.Text);
                }
                else MessageBox.Show($"_Игрока с таким ником нет_ ");
                del.Text = "";
                
            }
        }
        Team t1 = new Team();

        private /*async*/ void Form1_Load(object sender, EventArgs e)
        {
            //comboBox3.SelectedValueChanged += PresetLoad;
            TeamData();
            //string connectionString = "mongodb://localhost:27017";
            //MongoClient client = new MongoClient(connectionString);
            //var database = client.GetDatabase("Mafia");
            //var collection = database.GetCollection<Team>("teamdata");
            //var Teamcoll = /*await*/ collection.Find(x => x.TM_name != null).ToList();
            //foreach (var item in Teamcoll)
            //{
            //    comboBox3.Items.Add(item.TM_name);
            //}
        }
        public void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            //var collection = database.GetCollection<BsonDocument>("teamdata");
            var collection = database.GetCollection<Team>("teamdata");
            //Team t1 = new Team();

            t1.TM_name = comand.Text;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                t1.mafia_role.Add($"{ comboBox1.Items[i] }");
            }
            t1.butter_role = label8.Text;
            t1.sherif_role = label9.Text;
            t1.doc_role = label10.Text;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                t1.civilian_role.Add($"{comboBox2.Items[i]}");
            }
            //collection.InsertOne(t1.ToBsonDocument()); ;
            collection.InsertOne(t1);
            TeamData();
        }

        public void TeamData()
        {
            comboBox3.Items.Clear();
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<BsonDocument>("teamdata");
            var filter = new BsonDocument();
            var tm = collection.Find(filter).ToList();
            foreach (var doc in tm)
            {
                comboBox3.Items.Add($"{doc.GetValue("_id")}");
            }
            
        }

        //private void PresetLoad(object sender, EventArgs e)
        //{
        //    comboBox1.Items.Clear();
        //    comboBox2.Items.Clear();
        //    string connectionString = "mongodb://localhost:27017";
        //    MongoClient client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("Mafia");
        //    var collection = database.GetCollection<BsonDocument>("teamdata");
        //    var filter = new BsonDocument {

        //       {"_id",$"{comboBox3.SelectedItem}"},

        //    };
        //    var tm = collection.Find(filter).ToList();
        //    BsonValue mafia = null;
        //    BsonValue citizens = null;
        //    foreach (var doc in tm)
        //    {

        //        mafia = doc.GetValue("mafia_role");
        //        citizens = doc.GetValue("civilian_role");
        //        if (doc.GetValue("butter_role") != BsonNull.Value)
        //            label8.Text = $"{doc.GetValue("butter_role")}";
        //        if (doc.GetValue("butter_role") != BsonNull.Value)
        //            label9.Text = $"{doc.GetValue("sherif_role")}";
        //        if (doc.GetValue("butter_role") != BsonNull.Value)
        //            label10.Text = $"{doc.GetValue("doc_role")}";
        //    }
        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (mafia[i] != BsonNull.Value)
        //        {
        //            comboBox1.Items.Add($"{mafia[i]}");
        //        }
        //    }
        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (citizens[i] != BsonNull.Value)
        //        {
        //            comboBox2.Items.Add($"{citizens[i]}");
        //        }
        //    }
        //}



        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (listBox1.SelectedItem.ToString() != null)
                {
                    string d = listBox1.SelectedItem.ToString();
                    if (radioButton1.Checked == true)
                    {
                        if (comboBox1.Items.Count < 4)
                        {
                            comboBox1.Items.Add(d).ToString();
                        }
                        else { MessageBox.Show("Достигнуто максимальное кол-во игроков"); }
                    }

                    if (radioButton2.Checked == true && comboBox1.Items.Contains(d) != true)
                    {
                        label8.Text = d;
                    }

                    if (radioButton3.Checked == true && label8.Text != d && comboBox1.Items.Contains(d) != true) label9.Text = d;
                    if (radioButton4.Checked == true && comboBox1.Items.Contains(d) != true && label9.Text != d) label10.Text = d;
                    if (radioButton5.Checked == true && comboBox1.Items.Contains(d) != true && label10.Text != d)
                    {
                        if (comboBox2.Items.Count < 9)
                        {
                            if (comboBox2.Items.Contains(d) == false)
                            {
                                if (label9.Text != d && label8.Text != d)
                                    comboBox2.Items.Add(d);
                            }
                            else MessageBox.Show($"_Игрок_ {d} cуществует");
                        }
                        else { MessageBox.Show("Достигнуто максимальное кол-во игроков"); }
                    }
                    if (comboBox1.Items.Count != 0 && comboBox2.Items.Count != 0 && label8.Text != "" && label9.Text != "" && label10.Text != "")
                        panel2.Visible = true;
                }
            }
            catch
            {
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Cle_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0 && comboBox2.Items.Count != 0 && label8.Text != "" && label9.Text != "" && label10.Text != "")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                panel2.Visible = false;
            }
            else MessageBox.Show("Не заполнены остальные роли");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(!(listBox1.Items.Count < 16))
            {
                Random rnd = new Random();
                int[] random = new int[listBox1.Items.Count];
                for (int i = 0; i < random.Length-1; i++)
                {
                    int x = rnd.Next(0, listBox1.Items.Count);
                    if (!(random.Contains(x))) random[i] = x;
                    else i--;
                }
                comboBox1.Items.Add(listBox1.Items[random[0]].ToString());
                comboBox1.Items.Add(listBox1.Items[random[1]].ToString());
                comboBox1.Items.Add(listBox1.Items[random[2]].ToString());
                comboBox1.Items.Add(listBox1.Items[random[3]].ToString());
                label8.Text = listBox1.Items[random[4]].ToString();
                label9.Text = listBox1.Items[random[5]].ToString();
                label10.Text = listBox1.Items[random[6]].ToString();
                for (int i = 7; i < listBox1.Items.Count; i++)
                {
                    comboBox2.Items.Add(listBox1.Items[random[i]].ToString());
                }
                panel2.Visible = true;
            }
            else MessageBox.Show("Чтобы использоать эту функцию нужно, хотя бы 16 человек ");
            }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<Team>("teamdata");
            var Teamcoll = collection.Find(x => x.TM_name == comboBox3.SelectedItem.ToString()).ToList();
            foreach (var item in Teamcoll)
            {
                for (int i = 0; i < item.mafia_role.Count; i++)
                {
                    if (item.mafia_role[i] != null)
                        comboBox1.Items.Add(item.mafia_role[i].ToString());
                }
                //if (item.mafia_role[0] != null)
                //    comboBox1.Items.Add(item.mafia_role[0].ToString());
                //if (item.mafia_role[1] != null)
                //    comboBox1.Items.Add(item.mafia_role[1].ToString());
                //if (item.mafia_role[2] != null)
                //    comboBox1.Items.Add(item.mafia_role[2].ToString());
                //if (item.mafia_role[3] != null)
                //    comboBox1.Items.Add(item.mafia_role[3].ToString());
                label8.Text = item.butter_role.ToString();
                label9.Text = item.sherif_role.ToString();
                label10.Text = item.doc_role.ToString();
                for (int i = 0; i <item.civilian_role.Count; i++)
                {
                    if (item.civilian_role[i] != null)
                        comboBox2.Items.Add(item.civilian_role[i].ToString());
                }
                panel2.Visible = true;
            }
        }
    }
}
