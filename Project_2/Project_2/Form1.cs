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
        private double Calculate_CSO(int i,double m, double a)
        {
            double CSO = 0.0;
            // Wzór na CSO ~= 10*log10 z floor[(Ncso * (am)^2)] gdzie Ncso to liczba produktów mieszania w danym kanale (dla danej częstotliwości) 2 rzędu
            //TODO: jak obliczyć Ncso, bo reszta jest podana

            return CSO;
        }
        private double Calculate_CTB(int i, double m, double b)
        {
            double CTB = 0.0;
            // Wzór na CTB ~=10*log10 z floor[(Nctb * (1.5*b*m^2)^2)] gdzie Nctb to liczba produktów w danym kanale (dla danej częstotliwości) 3 rzędu
            // TODO: jak obliczyć Nctb, bo reszta jest podana
            return CTB;
        }
        private void Clear_Values()
        {
            n_channels.Clear();
            mod_id.Clear();
            value_a.Clear();
            value_b.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            results.Items.Clear();

            int N = int.Parse(n_channels.Text);
            double m = double.Parse(mod_id.Text);
            double a = double.Parse(value_a.Text);
            double b = double.Parse(value_b.Text);

            Clear_Values();


            for(int i=1; i<=N;i++)
            {
                double CSO = Calculate_CSO(i, m, a);
                double CTB = Calculate_CTB(i, m, b);
                string result = $"For channel {i}: CSO= {CSO} [dB], CTB={CTB} [dB]";
                results.Items.Add(result);
            }
        }
    }
}
