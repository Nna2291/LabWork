using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LabWork
{
    public partial class NewWork : Form
    {
        private string _filename = "";

        public string Filename { get => _filename; set => _filename = value; }

        public NewWork(string file, Labaratory data)
        {
          
            InitializeComponent();
            Filename = file;
            mainInfoPanel1.nametext = data.FirstName;
            mainInfoPanel1.lastnametext = data.LastName;
            mainInfoPanel1.grouptext = data.Group;
            mainInfoPanel1.LabNameText = data.Name;
            mainInfoPanel1.AimText = data.Aim;
            mainInfoPanel1.EquipmentText = data.Equipment;
            saveFileDialog1.Filter = "Text files(*.lab)|*.lab|All files(*.*)|*.*";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Filename == "") SavwAs_Click(sender, e);
            else
            {
                List<Labaratory> _data = new List<Labaratory>();
                _data.Add(new Labaratory()
                {
                    FirstName = mainInfoPanel1.nametext,
                    LastName = mainInfoPanel1.lastnametext,
                    Group = mainInfoPanel1.grouptext,
                    Name = mainInfoPanel1.LabNameText,
                    Aim = mainInfoPanel1.AimText,
                    Equipment = mainInfoPanel1.EquipmentText
                });

                string json = JsonConvert.SerializeObject(_data.ToArray());
                File.WriteAllText(Filename, json);
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            LabWork win = new();
            win.Show();
            Hide();     
        }


        private void SavwAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            List<Labaratory> _data = new List<Labaratory>();
            string filename = saveFileDialog1.FileName;
            _data.Add(new Labaratory()
            {
                FirstName = mainInfoPanel1.nametext,
                LastName = mainInfoPanel1.lastnametext,
                Group = mainInfoPanel1.grouptext,
                Name = mainInfoPanel1.LabNameText,
                Aim = mainInfoPanel1.AimText,
                Equipment = mainInfoPanel1.EquipmentText
            });

            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(filename, json);
            Filename = filename;
        }

        private void mainInfoPanel1_Load(object sender, EventArgs e)
        {

        }

        private void NewWork_Load(object sender, EventArgs e)
        {
            mainInfoPanel1.Show();
            exp2.Hide();
        }

        private void Exp1_Click(object sender, EventArgs e)
        {
            mainInfoPanel1.Hide();
            exp2.Show();

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel1.Show();
            exp2.Hide();
        }
    }
}

