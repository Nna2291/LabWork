using DotLiquid;
using Newtonsoft.Json;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WpfMath;

namespace Application
{
    public partial class Force_work : Form
    {
        private string _filename = "";
        public string Filename { get => _filename; set => _filename = value; }
        public Force_work(string file, Labaratory data)
        {
            InitializeComponent();

            Filename = file;
            mainInfoPanel1.nametext = data.FirstName;
            mainInfoPanel1.lastnametext = data.LastName;
            mainInfoPanel1.grouptext = data.Group;
            mainInfoPanel1.LabNameText = data.Name;
            mainInfoPanel1.AimText = data.Aim;
            mainInfoPanel1.EquipmentText = data.Equipment;
            force1.Dimension = data.Dim;
            tangens1.LengthText = data.Length;
            tangens1.HeightText = data.Height;
            tangens1.HeightTextPogr = data.HeightPogr;
            tangens1.LengthTextPogr = data.LengthPogr;
            saveFileDialog1.Filter = "Text files(*.lab)|*.lab|All files(*.*)|*.*";
            saveFileDialog2.Filter = "HTML files(*.html)|*.html|All files(*.*)|*.*";
            button1.Hide();
            pictureBox1.Hide();
        }

        private void force1_Load(object sender, EventArgs e)
        {

        }

        private void Exp1_Click(object sender, EventArgs e)
        {
            force1.Show();
            tangens1.Hide();
            button1.Hide();
            tangens1.Hide();
            pictureBox1.Hide();
            mainInfoPanel1.Hide();
        }

        private void mainInfoPanel1_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            force1.Hide();
            tangens1.Hide();
            button1.Hide();
            tangens1.Hide();
            pictureBox1.Hide();
            mainInfoPanel1.Show();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            List<Labaratory> _data = new List<Labaratory>();
            string filename = saveFileDialog1.FileName;
            _data.Add(new Labaratory()
            {
                WorkName = "Force_tr",
                FirstName = mainInfoPanel1.nametext,
                LastName = mainInfoPanel1.lastnametext,
                Group = mainInfoPanel1.grouptext,
                Name = mainInfoPanel1.LabNameText,
                Aim = mainInfoPanel1.AimText,
                Equipment = mainInfoPanel1.EquipmentText,
                Dim = force1.Dimension,
                Length = tangens1.LengthText,
                Height = tangens1.HeightText,
                LengthPogr = tangens1.LengthTextPogr,
                HeightPogr = tangens1.HeightTextPogr
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(filename, json);
            Filename = filename;
        }

        private void back_Click(object sender, EventArgs e)
        {
            LabWork win = new();
            win.Show();
            Hide();
        }

        private void solving_Click(object sender, EventArgs e)
        {
            force1.Hide();
            tangens1.Hide();
            button1.Show();
            tangens1.Hide();
            pictureBox1.Show();
            mainInfoPanel1.Hide();
            ;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Force_work_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Science trsy = force1.Dimension[^1];
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    throw new ScienceException("Нет измерений");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            Science dim = force1.Dimension[^1];
            double mu_max = Math.Round((dim.Force_graph + dim.Pogr_F) / (dim.Normal_reaction_graph - dim.Pogr_N), 2);
            double mu_min = Math.Round((dim.Force_graph - dim.Pogr_F) / (dim.Normal_reaction_graph + dim.Pogr_N), 2);
            double delta = Math.Round((mu_max - mu_min) / 2, 3);
            double mu = Math.Round((mu_max + mu_min) / 2, 3);
            string latex = @"\color{white}{
                \mu = \frac{F_t}{N}\\\\
                \mu_{max} = \frac{F_{max}}{N_{min}}\text{      }\mu_{min} = \frac{F_{min}}{N_{max}}\text{      }\mu_{avg}=\frac{\mu_{max} + \mu_{min}}{2}\text{      }\Delta\mu=\frac{\mu_{max} - \mu_{min}}{2}\text{      }\epsilon_{\mu} = \frac{\Delta\mu}{\mu}\\\\
                \mu_{max} = \frac{" + $"{Math.Round(dim.Force_graph + dim.Pogr_F, 3)} H" + @"}{" + $"{Math.Round(dim.Normal_reaction_graph - dim.Pogr_N, 3)} H" + @"} = " + $"{mu_max}" + @"\text{      }
                \mu_{min} = \frac{" + $"{Math.Round(dim.Force_graph - dim.Pogr_F, 3)} H" + @"}{" + $"{Math.Round(dim.Normal_reaction_graph + dim.Pogr_N, 3)} H" + @"} = " + $"{mu_min}" + @"\text{      }
                \mu_{avg}=\frac{" + $"{mu_max} + {mu_min}" + @"}{2}=" + $"{mu}" + @"\text{      }\Delta\mu=\frac{" + $"{mu_max} - {mu_min}" + @"}{2}=" + $"{delta}" + @"\text{      }\epsilon_{\mu} = \frac{" + $"{delta}" + @"}{" + $"{mu}" + @"}=" + $"{Math.Round(delta / mu * 100),0}" + @"\text{ %}         
                }";
            string fileName = @"..\formula.png";

            var parser = new TexFormulaParser();
            try
            {
                var formula = parser.Parse(latex);
                var pngBytes = formula.RenderToPng(40.0, 0.0, 0.0, "Times New Roman");
                File.WriteAllBytes(fileName, pngBytes);
                pictureBox1.ImageLocation = @"..\formula.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            catch (Exception)
            {

                return;
            }

        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                Science rr = force1.Dimension[^1];
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    throw new ScienceException("Нет измерений");
                }
                catch (ScienceException)
                {
                    return;
                }

            }

            Science dim = force1.Dimension[^1];
            double mu_max = Math.Round((dim.Force_graph + dim.Pogr_F) / (dim.Normal_reaction_graph - dim.Pogr_N), 2);
            double mu_min = Math.Round((dim.Force_graph - dim.Pogr_F) / (dim.Normal_reaction_graph + dim.Pogr_N), 2);
            double delta = Math.Round((mu_max - mu_min) / 2, 3);
            double mu = Math.Round((mu_max + mu_min) / 2, 3);
            string latex1 = @"\color{black}{
                \mu = \frac{F}{N}\\\\
                \mu_{max} = \frac{F_{max}}{N_{min}}\text{      }\mu_{min} = \frac{F_{min}}{N_{max}}\text{      }\mu_{avg}=\frac{\mu_{max} + \mu_{min}}{2}\text{      }\Delta\mu=\frac{\mu_{max} - \mu_{min}}{2}\text{      }\epsilon_{\mu} = \frac{\Delta\mu}{\mu}\\\\
                \mu_{max} = \frac{" + $"{Math.Round(dim.Force_graph + dim.Pogr_F, 3)} H" + @"}{" + $"{Math.Round(dim.Normal_reaction_graph - dim.Pogr_N, 3)} H" + @"} = " + $"{mu_max}" + @"\text{      }
                \mu_{min} = \frac{" + $"{Math.Round(dim.Force_graph - dim.Pogr_F, 3)} H" + @"}{" + $"{Math.Round(dim.Normal_reaction_graph + dim.Pogr_N, 3)} H" + @"} = " + $"{mu_min}" + @"\text{      }
                \mu_{avg}=\frac{" + $"{mu_max} + {mu_min}" + @"}{2}=" + $"{mu}" + @"\text{      }\Delta\mu=\frac{" + $"{mu_max} - {mu_min}" + @"}{2}=" + $"{delta}" + @"\text{      }\epsilon_{\mu} = \frac{" + $"{delta}" + @"}{" + $"{mu}" + @"}=" + $"{Math.Round(delta / mu * 100),0}" + @"\text{ %}         
                }";
            var parser = new TexFormulaParser();
            try
            {
                var formula1 = parser.Parse(latex1);
                var pngBytes1 = formula1.RenderToPng(40.0, 0.0, 0.0, "Times New Roman");
                string fileName1 = @"..\formulaforhtml.png";
                File.WriteAllBytes(fileName1, pngBytes1);
            }
            catch (Exception)
            {
                return;
            }

            var model = new PlotModel
            {
                Title = "График зависимости F(N)",
                PlotAreaBorderColor = OxyColors.Black,
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                SubtitleColor = OxyColors.Black,
            };
            model.Axes.Add
                (
                new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "N, Н"
                }
                );
            model.Axes.Add
                (
                    new LinearAxis
                    {
                        Position = AxisPosition.Left,
                        Title = "F тр, Н"
                    }
                );
            var scatterSeries = new ScatterSeries
            {
                MarkerFill = OxyColor.Parse("#000000"),
                MarkerType = MarkerType.Square
            };
            const int size = 3;
            List<double> D = new();
            List<double> B = new();
            List<double> C = new();
            foreach (Science values in force1.Dimension)
            {
                D.Add((values.Force_graph - values.Pogr_F) /
                       (values.Normal_reaction_graph + values.Pogr_N));
                B.Add((values.Force_graph + values.Pogr_F) /
                    (values.Normal_reaction_graph - values.Pogr_N));
                C.Add(values.Normal_reaction_graph);
                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(values.Pogr_N),
                    values.Force_graph - Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(values.Pogr_N),
                    values.Force_graph + Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(values.Pogr_N),
                    values.Force_graph - Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph,
                    values.Force_graph - Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(values.Pogr_N),
                    values.Force_graph,
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(values.Pogr_N),
                    values.Force_graph,
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(values.Pogr_N),
                    values.Force_graph + Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph,
                    values.Force_graph + Convert.ToDouble(values.Pogr_F),
                    size,
                    size));

            }
            model.Series.Add(scatterSeries);
            double d_final = D.Max();
            double b_final = B.Min();
            double c_final = C.Max();
            Func<double, double> kx = (x) => (d_final + b_final) / 2 * x;
            model.Series.Add(new FunctionSeries(kx, 0, c_final + 1, 0.1, "y = kx"));
            using (var stream = File.Create(@"..\gg.svg"))
            {
                var exporter = new SvgExporter { Width = 1000, Height = 600 };
                exporter.Export(model, stream);
            }
            Template template = Template.Parse(File.ReadAllText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Force.html")));
            string js = template.Render(Hash.FromAnonymousObject(new
            {
                graph = Path.GetFullPath(@"..\gg.svg"),
                formula = Path.GetFullPath(@"..\formulaforhtml.png"),
                dem = force1.Dimension,
                labname = mainInfoPanel1.LabNameText,
                aim = mainInfoPanel1.AimText,
                firstname = mainInfoPanel1.nametext,
                lastname = mainInfoPanel1.lastnametext,
                group = mainInfoPanel1.grouptext,
                equipment = mainInfoPanel1.EquipmentText,
                final = mainInfoPanel1.Finaltext,

            }));

            File.WriteAllText(saveFileDialog2.FileName, js);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            force1.Hide();
            tangens1.Hide();
            button1.Hide();
            tangens1.Show();
            pictureBox1.Hide();
            mainInfoPanel1.Hide();
        }

        private void Force_work_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
