using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frekvImasa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            frekvencija.placeHolderText = "frekvencija u Hz";
        }

        private void izracun_Click(object sender, EventArgs e)
        {
            try
            {
                double frekv = double.Parse(frekvencija.Text);

                if (frekv == 0)
                {
                    MessageBox.Show("Frekvencija ne može biti 0.");
                    return;
                }

                double Period1 = 1 / frekv;
                period.Text = "Period je: " + Period1.ToString("F3") + " s";
            }
            catch (FormatException)
            {
                MessageBox.Show("Molim vas unesite valjanu frekvenciju.");
            }
           
        }

        private void period_Click(object sender, EventArgs e)
        {

        }

        private void frekvencija_TextChanged(object sender, EventArgs e)
        {

        }

        private void povratak_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
        }
    }
}
