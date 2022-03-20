using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Application
{
    public partial class LabWork : Form
    {
        private const string File = "";



        public LabWork()
        {
            InitializeComponent();
            comboBox1.Items.Add("Сила трения");
            openFileDialog1.Filter = "Lab files(*.lab)|*.lab|All files(*.*)|*.*";

        }



        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                List<Labaratory> items = JsonConvert.DeserializeObject<List<Labaratory>>(json);
                Labaratory conte = items[0];
                switch (conte.WorkName)
                {
                    case "Force_tr":
                        Force_work window = new(File, conte);
                        Hide();
                        window.Show();
                        break;
                }
            }
        }

        private void LabWork_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = comboBox1.Text;
            switch (SelectedItem)
            {
                case "Сила трения":
                    Force_work window = new(File, new Labaratory()
                    {
                        WorkName = "Force_tr",
                        FirstName = File,
                        LastName = File,
                        Group = File,
                        Name = File,
                        Aim = File,
                        Equipment = File,
                        Final = File,
                        Length = File,
                        Height = File,
                        LengthPogr = File,
                        HeightPogr = File
                    });
                    Hide();
                    window.Show();
                    break;
            }
        }

        private void instruments_Click(object sender, EventArgs e)
        {
            Instrument instrument = new();
            Hide();
            instrument.Show();
        }

        private void LabWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
