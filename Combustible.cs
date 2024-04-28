using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IniciarCalculo_Click(object sender, EventArgs e)
        {
            double distanciaRecorrida = double.Parse(TextDistancia.Text);
            double rendimiento = double.Parse(TextRendimiento.Text);

            double resultado = distanciaRecorrida / rendimiento;

            TextTotal.Text = resultado.ToString();
        }

        private void EtiquetaMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}

