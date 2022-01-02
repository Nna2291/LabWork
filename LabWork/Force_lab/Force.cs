using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Application
{
    public partial class Force : UserControl
    {
        public Force()
        {
            InitializeComponent();
        }

        List<Science> dimension = new();
        DataTable table = new();


        public List<Science> Dimension { get => dimension; set => dimension = value; }
        public DataTable Table { get => table; set => table = value; }

        private void Force_Load(object sender, EventArgs e)
        {
            Table.Columns.Add("Вид поверхности", typeof(string));
            Table.Columns.Add("Число грузов", typeof(string));
            Table.Columns.Add("Сила нормальной реакции опоры N, Н", typeof(string));
            Table.Columns.Add("Сила трения F, H", typeof(string));
            var model = new PlotModel
            {
                PlotAreaBorderColor = OxyColors.White,
                TextColor = OxyColors.White,
                TitleColor = OxyColors.White,
                SubtitleColor = OxyColors.White,
            };
            model.Axes.Add
                (
                new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "F тр, Н"
                }
                );
            model.Axes.Add
                (
                    new LinearAxis
                    {
                        Position = AxisPosition.Left,
                        Title = "N, Н"
                    }
                );
            if (Dimension != null)
            {
                var scatterSeries = new ScatterSeries
                {
                    MarkerFill = OxyColor.Parse("#FFCB21"),
                    MarkerType = MarkerType.Square
                };
                const int size = 3;
                foreach (Science values in Dimension)
                {
                    Table.Rows.Add(values.Type_road, values.Number, values.Normal_reaction, values.Force);
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
                plotView1.Model = model;

            }
            else
            {
                Dimension = new();
            }
            dataGridView1.DataSource = Table;
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (Normal_force.Text == "" | plu_1.Text == "" | plu_2.Text == "" | Force_tr.Text == "")
            {
                try
                {
                    throw new ScienceException("Введите силу нормальной реакции опоры, силу трения и погрешность");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            try
            {
                string _temp = Normal_force.Text;
                Normal_force.Text = _temp.Replace(".", ",");
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
                string _temp = Force_tr.Text;
                Force_tr.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            if (!Normal_force.Text.Contains(","))
            {
                Normal_force.Text += ",";
            }

            if (!Force_tr.Text.Contains(",") & Force_tr.Text.Contains("."))
            {
                Force_tr.Text.Replace(".", ",");
            }
            if (!Force_tr.Text.Contains(","))
            {
                Force_tr.Text += ",";
            }
            try
            {
                if ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) >
                Normal_force.Text.Substring(Normal_force.Text.IndexOf(",")).Length)
                {
                    while ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) !=
                       Normal_force.Text.Substring(Normal_force.Text.IndexOf(",")).Length)
                    {
                        Normal_force.Text += "0";
                    }
                }

                if ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) >
                Force_tr.Text.Substring(Force_tr.Text.IndexOf(",")).Length)
                {
                    while ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) !=
                       Force_tr.Text.Substring(Force_tr.Text.IndexOf(",")).Length)
                    {
                        Force_tr.Text += "0";
                    }
                }

                if ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) <
                    Normal_force.Text.Substring(Normal_force.Text.IndexOf(",")).Length)
                {
                    while ((plu_1.Text.Substring(plu_1.Text.IndexOf(",")).Length) !=
                       Normal_force.Text.Substring(Normal_force.Text.IndexOf(",")).Length)
                    {
                        plu_1.Text += "0";
                    }
                }

                if ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) <
                    Force_tr.Text.Substring(Force_tr.Text.IndexOf(",")).Length)
                {
                    while ((plu_2.Text.Substring(plu_2.Text.IndexOf(",")).Length) !=
                       Force_tr.Text.Substring(Force_tr.Text.IndexOf(",")).Length)
                    {
                        Force_tr.Text += "0";
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }



            Dimension.Add(new Science(road_text.Text,
                number_weights.Text,
                Convert.ToDouble(plu_1.Text),
                Convert.ToDouble(plu_2.Text),
                $"{Normal_force.Text} ± {plu_1.Text}",
                Convert.ToDouble(Normal_force.Text),
                $"{Force_tr.Text} ± {plu_2.Text}",
                Convert.ToDouble(Force_tr.Text)));


            Science dim = Dimension[^1];
            Table.Rows.Add(dim.Type_road, dim.Number, dim.Normal_reaction, dim.Force);
            number_weights.Text = "";
            Normal_force.Text = "";
            Force_tr.Text = "";

            var model = new PlotModel
            {
                Title = "Example 1",
                PlotAreaBorderColor = OxyColors.White,
                TextColor = OxyColors.White,
                TitleColor = OxyColors.White,
                SubtitleColor = OxyColors.White,
            };
            int size = 3;
            var scatterSeries = new ScatterSeries
            {
                MarkerFill = OxyColor.Parse("#FFCB21"),
                MarkerType = MarkerType.Square
            };
            foreach (Science values in dimension)
            {

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(plu_1.Text),
                    values.Force_graph - Convert.ToDouble(plu_2.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(plu_1.Text),
                    values.Force_graph + Convert.ToDouble(plu_2.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                    values.Force_graph - Convert.ToDouble(plu_2.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph,
                    values.Force_graph - Convert.ToDouble(plu_2.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                   values.Normal_reaction_graph - Convert.ToDouble(plu_1.Text),
                   values.Force_graph,
                   size,
                   size));

                scatterSeries.Points.Add(new ScatterPoint(
                   values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                   values.Force_graph,
                   size,
                   size));

                scatterSeries.Points.Add(new ScatterPoint(
                   values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                   values.Force_graph + Convert.ToDouble(plu_2.Text),
                   size,
                   size));

                scatterSeries.Points.Add(new ScatterPoint(
                   values.Normal_reaction_graph,
                   values.Force_graph + Convert.ToDouble(plu_2.Text),
                   size,
                   size));

                scatterSeries.Points.Add(new ScatterPoint(
                   values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                   values.Force_graph + Convert.ToDouble(plu_2.Text),
                   size,
                   size));
            }
            model.Title = dim.Type_road;
            model.Series.Add(scatterSeries);
            plotView1.Model = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> D = new();
            List<double> B = new();
            List<double> C = new();
            foreach (Science el in dimension)
            {
                D.Add((el.Force_graph - el.Pogr_F) /
                    (el.Normal_reaction_graph + el.Pogr_N));
                B.Add((el.Force_graph + el.Pogr_F) /
                    (el.Normal_reaction_graph - el.Pogr_N));
                C.Add(el.Normal_reaction_graph);
            }
            try
            {
                double jss = D.Max();
            }
            catch (InvalidOperationException)
            {
                try
                {
                    throw new ScienceException("Отсутствуют данные");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            double d_final = D.Max();
            double b_final = B.Min();
            double c_final = C.Max();
            Func<double, double> kx = (x) => (d_final + b_final) / 2 * x;
            plotView1.Model.Series.Add(new FunctionSeries(kx, 0, c_final + 1, 0.1, "y = kx"));
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
