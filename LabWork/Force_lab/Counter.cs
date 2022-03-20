using System;
using System.IO;
using System.Windows.Forms;
using WpfMath;

namespace Application
{
    public partial class Counter : UserControl
    {
        public Counter()
        {
            InitializeComponent();
        }
        private Science _data;
        
        public Science Data
        {
            set => _data = value;
            get { return _data; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Data == null)
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
            Science dim = Data;
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
    }
}
