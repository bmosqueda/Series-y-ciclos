using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series_y_ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int repeticiones = Convert.ToInt32(txtRep.Text);

            txtResultado.Text = logNatural(num, repeticiones).ToString();
        }

        private double logNatural(int num, int repeticiones)
        {
            double factor = (double)(num - 1) / num;
            double resultado = 0;

            for( int i = 2; i <= repeticiones; i++ )
            {
                resultado += ( (double)1 / i ) * Math.Pow(factor, i);
            }

            return resultado;
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int repeticiones = Convert.ToInt32(txtRep.Text);

            txtResultado.Text = seno(num, repeticiones).ToString();
        }

        private double seno(int num, int repeticiones)
        {
            long factorial = 1;
            double resultado = 0;
            int exponente = 1;

            for( int i = 1; i <= repeticiones; i++, exponente += 2 )
            {
                resultado = (i-1) % 2 == 0 ? resultado + (Math.Pow(num,exponente) / factorial ) : resultado - (Math.Pow(num, exponente) / factorial);
                factorial *= (i + 1) * (i + 2);
            }

            return resultado;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int repeticiones = Convert.ToInt32(txtRep.Text);

            txtResultado.Text = coseno(num, repeticiones).ToString();
        }

        private double coseno(int num, int repeticiones)
        {
            long factorial = 2;
            double resultado = 1;
            int exponente = 2;

            for (int i = 1; i < repeticiones; i++, exponente += 2)
            {
                resultado = (i-1) % 2 == 0 ? resultado + (Math.Pow(num, exponente) / factorial) : resultado - (Math.Pow(num, i) / factorial);
                factorial *= (i + 1) * (i + 2);
            }

            return resultado;
        }
    }
}
