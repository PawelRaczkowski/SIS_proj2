using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private double Calculate_CSO(int i, double m, double a, List<double> channels, List<double> all_dso_products, double delta_f)
        {
            double CSO = 0.0;
            // Wzór na CSO ~= 10*log10 z floor[(Ncso * (am)^2)] gdzie Ncso to liczba produktów mieszania w danym kanale (dla danej częstotliwości) 2 rzędu
            //TODO: jak obliczyć Ncso, bo reszta jest podana

            //Ncso
            int Ncso = 0;
            for (int j=0; j<all_dso_products.Count; j++)
            {

                if (all_dso_products[j]<=channels[i]+delta_f/2 && all_dso_products[j]>= channels[i]-delta_f/2) 
                {
                    Ncso = Ncso + 1;
                }
            }

            //CSO
            CSO = 10 * Math.Log((Math.Floor(Ncso*Math.Pow(a*m, 2))), 10.0);

            return CSO;
        }
        private double Calculate_CTB(int i, double m, double b, List<double> channels, List<double> all_dto_products, double delta_f)
        {
            double CTB = 0.0;
            // Wzór na CTB ~=10*log10 z floor[(Nctb * (1.5*b*m^2)^2)] gdzie Nctb to liczba produktów w danym kanale (dla danej częstotliwości) 3 rzędu
            // TODO: jak obliczyć Nctb, bo reszta jest podana

            //Nctb
            int Nctb = 0;
            for (int j = 0; j < all_dto_products.Count; j++)
            {
                if (all_dto_products[j] <= channels[i] + delta_f / 2 && all_dto_products[j] >= channels[i] - delta_f / 2)
                {
                    Nctb = Nctb + 1;
                }
            }

            //CTB
            CTB = 10 * Math.Log((Math.Floor(Nctb * Math.Pow(b * 1.5 * Math.Pow(m,2), 2))), 10.0);
            return CTB;
        }
        private void Clear_Values()
        {
            n_channels.Clear();
            mod_id.Clear();
            value_a.Clear();
            value_b.Clear();
            value_f0.Clear();
            value_delta_f.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            results.Items.Clear();

            int N = int.Parse(n_channels.Text);
            double m = double.Parse(mod_id.Text);
            double a = double.Parse(value_a.Text);
            double b = double.Parse(value_b.Text);
            double f0 = double.Parse(value_f0.Text);
            double delta_f = double.Parse(value_delta_f.Text);

            Clear_Values();

            List<double> channels = new List<double>();
            for (int i=0; i<N; i++)
            {
                channels.Add(f0+i*delta_f);
            }
            //PrintChannels(channels);
            //debugginglist.Items.Add("Printing DSO products...\n\n\n");

            //Wyznaczenie produktów 2-rzedu DSO
            List<double> all_dso_products = new List<double>();
            for (int k = 0; k < channels.Count; k++)
            {
                for (int j = 0; j < channels.Count; j++)
                {
                    all_dso_products.Add(Math.Abs(channels[k] + channels[j]));
                    all_dso_products.Add(Math.Abs(channels[k] - channels[j]));
                }
            }
            //PrintChannels(all_dso_products);
            //Wyznaczenie produktów 3-rzedu DTO
            List<double> all_dto_products = new List<double>();
            for (int k = 0; k < channels.Count; k++)
            {
                for (int j = 0; j < channels.Count; j++)
                {
                    for (int x = 0; x < channels.Count; x++)
                    {
                        all_dto_products.Add(Math.Abs(channels[k] + channels[j] + channels[x]));
                        all_dto_products.Add(Math.Abs(channels[k] + channels[j] - channels[x]));
                    }
                }
            }

            for (int i=0; i<channels.Count; i++)
            {
                double CSO = Calculate_CSO(i, m, a, channels, all_dso_products,delta_f);
                double CTB = Calculate_CTB(i, m, b, channels, all_dto_products,delta_f);
                string result = $"For channel {i+1}: CSO= {CSO} [dB], CTB={CTB} [dB]";
                results.Items.Add(result);
            }
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
