using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

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
            saveFileDialog2.Filter = "PDF files(*.pdf)|*.lab|All files(*.*)|*.*";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Filename == "") SavwAs_Click(sender, e);
            else
            {
                List<Labaratory> _data = new();
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


        private void NewWork_Load(object sender, EventArgs e)
        {
            mainInfoPanel1.Show();
            experiment1.Hide();
        }

        private void Exp1_Click(object sender, EventArgs e)
        {
            mainInfoPanel1.Hide();
            experiment1.Show();

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel1.Show();
            experiment1.Hide();
        }


        private void experiment1_Load_1(object sender, EventArgs e)
        {

        }

        private void Export_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = mainInfoPanel1.LabNameText;

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            string[] data = { mainInfoPanel1.LabNameText,
                mainInfoPanel1.nametext,
                mainInfoPanel1.lastnametext,
                mainInfoPanel1.grouptext,
                mainInfoPanel1.AimText,
                mainInfoPanel1.EquipmentText
                  };

            int j = 0;
            foreach(string learn in data) {
                gfx.DrawString(learn, font, XBrushes.Black,
                      new XRect(0, 0, page.Width, page.Height + j),
                      XStringFormats.Center);
                j += 65;
            }
                

            

            
            
            document.Save(@"C:\Users\Коля\Documents\ex.pdf");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

