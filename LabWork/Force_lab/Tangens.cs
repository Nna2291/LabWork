using System;
using System.IO;
using System.Windows.Forms;
using WpfMath;

namespace Application
{
    public partial class Tangens : UserControl
    {
        public string LengthText { get => _length; set => _length = value; }
        private string _length;

        public string HeightText { get => _height; set => _height = value; }
        private string _height;
        public string LengthTextPogr { get => _lengthpogr; set => _lengthpogr = value; }
        private string _lengthpogr;

        public string HeightTextPogr { get => _heightpogr; set => _heightpogr = value; }
        private string _heightpogr;
        public Tangens()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Length.Text == "" | plu_1.Text == "" | plu_2.Text == "" | Height.Text == "")
            {
                try
                {
                    throw new ScienceException("Введите длину, высоту и погрешность");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            try
            {
                string _temp = Length.Text;
                Length.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            try
            {
                string _temp = plu_1.Text;
                plu_1.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            try
            {
                string _temp = plu_2.Text;
                plu_2.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            try
            {
                string _temp = Height.Text;
                Height.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            if (!Length.Text.Contains(","))
            {
                Length.Text += ",";
            }

            if (!Height.Text.Contains(",") & Height.Text.Contains("."))
            {
                Height.Text.Replace(".", ",");
            }
            if (!Height.Text.Contains(","))
            {
                Height.Text += ",";
            }
            try
            {
                if ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) >
                Length.Text.Substring(Length.Text.IndexOf(",")).Length)
                {
                    while ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) !=
                       Length.Text.Substring(Length.Text.IndexOf(",")).Length)
                    {
                        Length.Text += "0";
                    }
                }

                if ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) >
                Height.Text.Substring(Height.Text.IndexOf(",")).Length)
                {
                    while ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) !=
                       Height.Text.Substring(Height.Text.IndexOf(",")).Length)
                    {
                        Height.Text += "0";
                    }
                }

                if ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) <
                    Length.Text.Substring(Length.Text.IndexOf(",")).Length)
                {
                    while ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) !=
                       Length.Text.Substring(Length.Text.IndexOf(",")).Length)
                    {
                        plu_1.Text += "0";
                    }
                }

                if ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) <
                    Height.Text.Substring(Height.Text.IndexOf(",")).Length)
                {
                    while ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) !=
                       Height.Text.Substring(Height.Text.IndexOf(",")).Length)
                    {
                        plu_2.Text += "0";
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            label1.Text = $"l = ({Length.Text} ± {plu_1.Text}), см";
            label4.Text = $"h = ({Height.Text} ± {plu_2.Text}), см";
            _height = Height.Text;
            _length = Length.Text;
        }

        private void Tangens_Load(object sender, EventArgs e)
        {
            Length.Text = LengthText;
            Height.Text = HeightText;
            plu_1.Text = LengthTextPogr;
            plu_2.Text = HeightTextPogr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" | label4.Text == "")
            {
                try
                {
                    throw new ScienceException("Данные не установлены");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            double h_max = Convert.ToDouble(Height.Text) + Convert.ToDouble(plu_2.Text);
            double h_min = Convert.ToDouble(Height.Text) - Convert.ToDouble(plu_2.Text);
            double l_max = Convert.ToDouble(Length.Text) + Convert.ToDouble(plu_1.Text);
            double l_min = Convert.ToDouble(Length.Text) - Convert.ToDouble(plu_1.Text);
            double mu_max = Math.Round(h_max / Math.Sqrt(Math.Pow(l_min, 2) - Math.Pow(h_max, 2)), 2, MidpointRounding.AwayFromZero);
            double mu_min = Math.Round(h_min / Math.Sqrt(Math.Pow(l_max, 2) - Math.Pow(h_min, 2)), 2, MidpointRounding.AwayFromZero);
            double mu_avg = Math.Round((mu_max + mu_min) / 2, 2, MidpointRounding.AwayFromZero);
            double delta_mu_fir = Math.Round((mu_max - mu_min) / 2, 5);
            double delta_mu = Math.Round(delta_mu_fir, 2, MidpointRounding.AwayFromZero);
            double eps_mu = Math.Round(delta_mu / mu_avg * 100);
            string latex = @"\color{white}{
            s = \sqrt{l^2-h^2}\\\\
            \mu = \tan(\alpha)=\frac{h}{s}\\\\
            \mu = \mu_{avg} \pm \Delta\mu\\\\
            \mu_{max} = \frac{h_{max}}{s_{min}} = \frac{h_{max}}{\sqrt{l_{min}^2-h_{max}^2}}\\\\
            \mu_{min} = \frac{h_{min}}{s_{max}} = \frac{h_{min}}{\sqrt{l_{max}^2-h_{min}^2}}\\\\
            \mu_{avg} = \frac{\mu_{max}+\mu_{min}}{2}\\\\
            \Delta\mu = \frac{\mu_{max}-\mu_{min}}{2}\\\\
            \epsilon_{\mu} = \frac{\Delta\mu}{\mu} * 100\text{%}\\\\

            \mu_{max} = \frac{" + $"{h_max}" + @"}{\sqrt{" + $"{l_min}" + @"^2-" + $"{h_max}" + @"^2}}\approx" + $"{mu_max}" + @"\\\\
            \mu_{min} = \frac{" + $"{h_min}" + @"}{\sqrt{" + $"{l_max}" + @"^2-" + $"{h_min}" + @"^2}}\approx" + $"{mu_min}" + @"\\\\
            \mu_{avg} = \frac{" + $"{mu_max}" + @"+" + $"{mu_min}" + @"}{2}\approx" + $"{mu_avg}" + @"\\\\
            \Delta\mu = \frac{" + $"{mu_max}" + @"-" + $"{mu_min}" + @"}{2}\approx" + $"{delta_mu}" + @"\\\\
            \epsilon_{\mu} = \frac{" + $"{delta_mu}" + @"}{" + $"{mu_avg}" + @"} * 100\text{%}\approx" + $"{eps_mu}" + @"\text{%}\\\\
}";
            string fileName = @"..\formula_tangens.png";
            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var pngBytes = formula.RenderToPng(40.0, 0.0, 0.0, "Times New Roman");
            File.WriteAllBytes(fileName, pngBytes);
            pictureBox1.ImageLocation = fileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
