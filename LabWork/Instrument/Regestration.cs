using System;
using System.Data;
using System.Windows.Forms;

namespace Application
{
    public partial class Regestration : UserControl
    {
        private void Check(TextBox value1, TextBox force)
        {
            try
            {
                string _temp = value1.Text;
                value1.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            try
            {
                string _temp = force.Text;
                force.Text = _temp.Replace(".", ",");
            }
            catch (Exception)
            { }
            if (value1.Text[value1.Text.IndexOf(",")..].Length <
                    force.Text.Substring(force.Text.IndexOf(",")).Length)
            {
                while (value1.Text[value1.Text.IndexOf(",")..].Length !=
                   force.Text[force.Text.IndexOf(",")..].Length)
                {
                    value1.Text += "0";
                }
            }
            if (value1.Text[value1.Text.IndexOf(",")..].Length >
                    force.Text[force.Text.IndexOf(",")..].Length)
            {
                string text = value1.Text;
                while (value1.Text[text.IndexOf(",")..].Length !=
                   force.Text[force.Text.IndexOf(",")..].Length)
                {
                    force.Text += "0";
                }
            }
        }
        public Regestration()
        {
            InitializeComponent();
        }
        DataTable table = new();
        public DataTable Table { get => table; set => table = value; }

        private void Regestration_Load(object sender, EventArgs e)
        {
            data_view.DataSource = Table;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (column_name.Text == "" | dimension.Text == "")
            {
                try
                {
                    throw new ScienceException("Введите измеряемую велечину и единицы измерения");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            if (Table.Columns.Count == 2)
            {
                try
                {
                    throw new ScienceException("Количество столбцов не может быть больше чем 2");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            Table.Columns.Add($"{column_name.Text}, {dimension.Text}", typeof(string));
        }

        private void column_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Table.Columns.Count != 2)
            {
                try
                {
                    throw new ScienceException("Количество столбцов должно быть равно 2");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            if (pogr2.Text == "" | pogr1.Text == "" |
                value1.Text == "" | value2.Text == "")
            {
                try
                {
                    throw new ScienceException("Введите все значения");
                }
                catch (ScienceException)
                {
                    return;
                }
            }
            if (!value1.Text.Contains(","))
            {
                value1.Text += ",";
            }

            if (!value2.Text.Contains(",") & value2.Text.Contains("."))
            {
                value2.Text.Replace(".", ",");
            }
            if (!value2.Text.Contains(","))
            {
                value2.Text += ",";
            }
            try
            {
                Check(pogr1, value1);
                Check(pogr2, value2);
            }
            catch (ArgumentOutOfRangeException)
            {

                try
                {
                    throw new ScienceException("Некорректный формат данных");
                }
                catch (ScienceException)
                {
                    return;
                }
            }

            Table.Rows.Add($"{value1.Text}±{pogr1.Text}",
                $"{value2.Text}±{pogr2.Text}");
        }
    }
}
