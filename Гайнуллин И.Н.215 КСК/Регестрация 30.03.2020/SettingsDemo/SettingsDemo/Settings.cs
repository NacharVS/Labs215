using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SettingsDemo
{

    public class Settings
    {

        public static Settings GetSettings()
        {
            Settings settings = null;
            string filename = Globals.SettingsFile;


            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));
                    settings = (Settings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else
            {
                settings = new Settings();
            }

            return settings;
        }


        public void Save()
        {
            string filename = Globals.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename);


            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(fs, this);
                fs.Close();
            }
        }


        public string Login { get; set; }

        public string Pasword { get; set; }

        public string EMAIL { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }

    }
}
