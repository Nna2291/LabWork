using System;
using System.IO;

using System.Windows.Forms;

using WpfMath;

namespace Application
{
    public partial class Solution : UserControl
    {
        public Force mpo;
        public Solution()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string latex = @"\color{white}{
                F_t = F \text{ трения}\\\\
                F_t=\mu N\\\\
                \mu = \frac{F_t}{N}\\\\
                \mu_{max} = \frac{F_{t max}}{N_{min}}\text{      }\mu_{min} = \frac{F_{t min}}{N_{max}}\\\\
                \mu_{max} = \frac{" + $"{mpo.Dimension[^1].Force_graph}" + @"}{N_{min}}\text{      }\mu_{min} = \frac{F_{t min}}{N_{max}}\\\\
                
                }";
            string fileName = @"..\formula.png";
            var parser = new TexFormulaParser();
            try
            {
                var formula = parser.Parse(latex);
                var pngBytes = formula.RenderToPng(40.0, 0.0, 0.0, "Times New Roman");
                File.WriteAllBytes(fileName, pngBytes);
                pb1.ImageLocation = @"..\formula.png";
                pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
