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
        public Science Data { get => force1.Dimension[^1]; }
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
            mainInfoPanel1.Finaltext = data.Final;
            force1.Dimension = data.Dim;
            tangens1.LengthText = data.Length;
            tangens1.HeightText = data.Height;
            tangens1.HeightTextPogr = data.HeightPogr;
            tangens1.LengthTextPogr = data.LengthPogr;
            saveFileDialog1.Filter = "Text files(*.lab)|*.lab|All files(*.*)|*.*";
            saveFileDialog2.Filter = "HTML files(*.html)|*.html|All files(*.*)|*.*";
            try
            {
                counter1.Data = Data;
            }
            catch (Exception)
            {

            }
            
        }

        private void force1_Load(object sender, EventArgs e)
        {

        }

        private void Exp1_Click(object sender, EventArgs e)
        {
            force1.Show();
            tangens1.Hide();
            mainInfoPanel1.Hide();
            counter1.Hide();
        }

        private void mainInfoPanel1_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            force1.Hide();
            counter1.Hide();
            tangens1.Hide();
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
                Final = mainInfoPanel1.Finaltext,
                Dim = force1.Dimension,
                Length = tangens1.LengthTextHtml,
                Height = tangens1.HeightTextHtml,
                LengthPogr = tangens1.LengthPogrTextHtml,
                HeightPogr = tangens1.HeightPogrTextHtml
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
            mainInfoPanel1.Hide();
            counter1.Show();
            try
            {
                counter1.Data = Data;
            }
            catch (Exception)
            {

            }
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
            try
            {
                if (tangens1.HeightTextHtml == null & tangens1.LengthTextHtml == null)
                {
                    try
                    {
                        throw new ScienceException("Не установлена высота или длина");
                    }
                    catch (ScienceException)
                    {
                        return;
                    }
                }
                string w = tangens1.HeightTextHtml;
                string y = tangens1.LengthTextHtml;
                string s = tangens1.HeightPogrTextHtml;
                string d = tangens1.LengthPogrTextHtml;
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    throw new ScienceException("Не установлена высота или длина");
                }
                catch (ScienceException)
                {
                    return;
                }

            }
            string height = tangens1.HeightTextHtml;
            string length = tangens1.LengthTextHtml;
            string plu_1 = tangens1.HeightPogrTextHtml;
            string plu_2 = tangens1.LengthPogrTextHtml;
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


            double h_max = Convert.ToDouble(height) + Convert.ToDouble(plu_2);
            double h_min = Convert.ToDouble(height) - Convert.ToDouble(plu_2);
            double l_max = Convert.ToDouble(length) + Convert.ToDouble(plu_1);
            double l_min = Convert.ToDouble(length) - Convert.ToDouble(plu_1);
            double mu_max_tan = Math.Round(h_max / Math.Sqrt(Math.Pow(l_min, 2) - Math.Pow(h_max, 2)), 2, MidpointRounding.AwayFromZero);
            double mu_min_tan = Math.Round(h_min / Math.Sqrt(Math.Pow(l_max, 2) - Math.Pow(h_min, 2)), 2, MidpointRounding.AwayFromZero);
            double mu_avg = Math.Round((mu_max_tan + mu_min_tan) / 2, 2, MidpointRounding.AwayFromZero);
            double delta_mu_fir = Math.Round((mu_max_tan - mu_min_tan) / 2, 5);
            double delta_mu = Math.Round(delta_mu_fir, 2, MidpointRounding.AwayFromZero);
            double eps_mu = Math.Round(delta_mu / mu_avg * 100);
            string latex2 = @"\color{black}{
            s = \sqrt{l^2-h^2}\text{      }
            \mu = \tan(\alpha)=\frac{h}{s}\text{      }
            \mu = \mu_{avg} \pm \Delta\mu\\\\
            \mu_{max} = \frac{h_{max}}{s_{min}} = \frac{h_{max}}{\sqrt{l_{min}^2-h_{max}^2}}\text{      }
            \mu_{min} = \frac{h_{min}}{s_{max}} = \frac{h_{min}}{\sqrt{l_{max}^2-h_{min}^2}}\text{      }
            \mu_{avg} = \frac{\mu_{max}+\mu_{min}}{2}\text{      }
            \Delta\mu = \frac{\mu_{max}-\mu_{min}}{2}\\\\
            \epsilon_{\mu} = \frac{\Delta\mu}{\mu} * 100\text{%}\\\\

            \mu_{max} = \frac{" + $"{h_max}" + @"}{\sqrt{" + $"{l_min}" + @"^2-" + $"{h_max}" + @"^2}}\approx" + $"{mu_max_tan}" + @"\text{      }
            \mu_{min} = \frac{" + $"{h_min}" + @"}{\sqrt{" + $"{l_max}" + @"^2-" + $"{h_min}" + @"^2}}\approx" + $"{mu_min}" + @"\text{      }
            \mu_{avg} = \frac{" + $"{mu_max_tan}" + @"+" + $"{mu_min_tan}" + @"}{2}\approx" + $"{mu_avg}" + @"\text{      }
            \Delta\mu = \frac{" + $"{mu_max_tan}" + @"-" + $"{mu_min_tan}" + @"}{2}\approx" + $"{delta_mu}" + @"\\\\
            \mu = " + $"{mu_avg}" + @" \pm " + $"{delta_mu}" + @"\\\\
            \epsilon_{\mu} = \frac{" + $"{delta_mu}" + @"}{" + $"{mu_avg}" + @"} * 100\text{%}\approx" + $"{eps_mu}" + @"\text{%}\\\\
}";
            var parser = new TexFormulaParser();
            try
            {
                var formula1 = parser.Parse(latex1);
                var pngBytes1 = formula1.RenderToPng(30.0, 0.0, 0.0, "Times New Roman");
                string fileName1 = @"..\formulaforhtml.png";
                File.WriteAllBytes(fileName1, pngBytes1);
                var formula_tan = parser.Parse(latex2);
                var pngBytes2 = formula_tan.RenderToPng(30.0, 0.0, 0.0, "Times New Roman");
                string fileName2 = @"..\formulaforhtml_tan.png";
                File.WriteAllBytes(fileName2, pngBytes2);
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
            Force_HTML file = new();
            Template template = Template.Parse(file.html);
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
                length = length,
                height = height,
                len_pogr = plu_1,
                h_pogr = plu_2,
                formula_tan = Path.GetFullPath(@"..\formulaforhtml_tan.png")
            }));

            File.WriteAllText(saveFileDialog2.FileName, js);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            force1.Hide();
            counter1.Hide();
            tangens1.Show();
            mainInfoPanel1.Hide();
        }

        private void Force_work_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
