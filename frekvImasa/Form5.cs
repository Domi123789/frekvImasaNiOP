using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frekvImasa
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            duzina.PlaceholderText = "duzina";
            sirina.PlaceholderText = "sirina";
            visina.PlaceholderText = "visina";
            gustoca.PlaceholderText = "gustoca";
        }

        private void izracun_Click(object sender, EventArgs e)
        {
            try
            {
                double duzina1 = double.Parse(duzina.Text);
                double sirina1 = double.Parse(sirina.Text);
                double visina1 = double.Parse(visina.Text);
                double gustoca1 = double.Parse(gustoca.Text);

                double volumen = duzina1 * sirina1 * visina1;

                double masa = volumen * gustoca1;

                Masa.Text = "Masa je: " + masa.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Molim vas unesite valjane brojeve za dužinu, širinu, visinu i gustoću.");
            }
        }

        private void povratak_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
        }
    }
}
