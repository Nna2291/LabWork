using System;
using System.Windows.Forms;

namespace Application
{
    public partial class Instrument : Form
    {
        public Instrument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regestration1.Show();
            analysis1.Hide();
        }

        private void Instrument_Load(object sender, EventArgs e)
        {

        }

        private void Instrument_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regestration1.Hide();
            analysis1.Show();
        }
    }
}
