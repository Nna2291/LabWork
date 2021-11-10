using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class LabWork : Form
    {
        private const string File = "";

        public LabWork()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Lab files(*.lab)|*.lab|All files(*.*)|*.*";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            NewWork window = new(File, new Labaratory()
            {
                
                FirstName = File,
                LastName = File,
                Group = File,
                Name =File,
                Aim =File,
                Equipment = File
            }) ;
            this.Hide();
            window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            using (StreamReader r = new StreamReader(filename)) {
                string json = r.ReadToEnd();
                List<Labaratory> items = JsonConvert.DeserializeObject<List<Labaratory>>(json);
                Labaratory conte = items[0];
                NewWork window = new(filename, conte);
                this.Hide();
                window.Show();
            }
        }
    }
}
