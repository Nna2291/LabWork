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

        private void Force_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Вид поверхности", typeof(string));
            table.Columns.Add("Число грузов", typeof(double));
            table.Columns.Add("Сила нормальной реакции опоры N, Н", typeof(double));
            table.Columns.Add("Сила трения F, H", typeof(double));

            dataGridView1.DataSource = table;        
        }

        private void update_Click(object sender, EventArgs e)
        {
            dimension.Add(new Science(road_text.Text, Convert.ToDouble(number_weights.Text),
                Convert.ToDouble(Normal_force.Text), Convert.ToDouble(Force_tr.Text)));
         Science dim = dimension[^1];
         table.Rows.Add(dim.type_road, dim.number, dim.normal_reaction, dim.force);
        }
        
    }

    class Science
    {
        public string type_road;
        public double number;
        public double normal_reaction;
        public double force;

        public Science(string _type_road, double _number, double _normal_reaction, double _force)
        {
            type_road = _type_road;
            number = _number;
            normal_reaction = _normal_reaction;
            force = _force;
        }
    }
}
