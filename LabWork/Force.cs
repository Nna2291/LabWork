using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    
    public partial class Force : UserControl
    {
        
        public Force()
        {
            InitializeComponent();
        }

        List<Science> dimension = new();
        DataTable table = new();

        internal List<Science> Dimension { get => dimension; set => dimension = value; }
        public DataTable Table { get => table; set => table = value; }

        private void Force_Load(object sender, EventArgs e)
        {
            Table.Columns.Add("Вид поверхности", typeof(string));
            Table.Columns.Add("Число грузов", typeof(string));
            Table.Columns.Add("Сила нормальной реакции опоры N, Н", typeof(string));
            Table.Columns.Add("Сила трения F, H", typeof(string));

            dataGridView1.DataSource = Table;
            
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
               string _temp = Normal_force.Text;
                Normal_force.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            {}
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
            {}
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
                error.Text = "Некорректный ввод данных!\nПовторите измерения";
                return;
            }
            

            
            Dimension.Add(new Science(road_text.Text, number_weights.Text, $"{Normal_force.Text} +- {plu_1.Text}",
                Convert.ToDouble(Normal_force.Text), $"{Force_tr.Text} +- {plu_2.Text}", Convert.ToDouble(Force_tr.Text)));


            Science dim = Dimension[^1];
        Table.Rows.Add(dim.Type_road, dim.Number, dim.Normal_reaction, dim.Force);
        road_text.Text = "";
        number_weights.Text = "";
        Normal_force.Text = "";
        Force_tr.Text = "";
         var myModel = new PlotModel
        {
            Title = "Example 1",
            PlotAreaBorderColor = OxyColors.White,
            TextColor = OxyColors.White,
            TitleColor = OxyColors.White,
            SubtitleColor = OxyColors.White,
            PlotAreaBackground = OxyColors.Undefined,
        };

            int size = 3;
            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Square };
            foreach (Science values in Dimension)
   
            {
                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(plu_1.Text), 
                    values.Force_graph - Convert.ToDouble(plu_1.Text), 
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph - Convert.ToDouble(plu_1.Text),
                    values.Force_graph + Convert.ToDouble(plu_1.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                    values.Force_graph - Convert.ToDouble(plu_1.Text),
                    size,
                    size));

                scatterSeries.Points.Add(new ScatterPoint(
                    values.Normal_reaction_graph + Convert.ToDouble(plu_1.Text),
                    values.Force_graph + Convert.ToDouble(plu_1.Text),
                    size,
                    size));
            }
            myModel.Series.Add(scatterSeries);
        plotView1.Model = myModel;
            error.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Func<double, double> kx = (x) => dimension[^1].Force_graph / dimension[^1].Normal_reaction_graph * x;
            plotView1.Model.Series.Add(new FunctionSeries(kx, 0, 1000, 0.1, "y = kx"));
            
        }

        
    }

    class Science
    {
        private string type_road;
        private string number;
        private string normal_reaction;
        private double normal_reaction_graph;
        private string force;
        private double force_graph;

        public string Type_road { get => type_road; set => type_road = value; }
        public string Number { get => number; set => number = value; }
        public string Normal_reaction { get => normal_reaction; set => normal_reaction = value; }
        public double Normal_reaction_graph { get => normal_reaction_graph; set => normal_reaction_graph = value; }
        public string Force { get => force; set => force = value; }
        public double Force_graph { get => force_graph; set => force_graph = value; }

        public Science(string _type_road, string _number, string _normal_reaction, 
            double _normal_reaction_graph, string _force, double _force_graph)
        {
            Type_road = _type_road;
            Number = _number;
            Normal_reaction = _normal_reaction;
            Force = _force;
            Normal_reaction_graph = _normal_reaction_graph;
            Force_graph = _force_graph;
        }
    }
}
