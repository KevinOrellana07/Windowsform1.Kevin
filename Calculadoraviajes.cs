using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CalcularTiempoBtn_Click(object sender, EventArgs e)
        {
            double distancia = double.Parse(TextDistancia.Text);
            double velocidad = double.Parse(TextVelocidad.Text);

            double tiempoEstimado = distancia / velocidad;

            MessageBox.Show("Hola, el tiempo estimado de viaje es " + tiempoEstimado + " horas");
        }

        private void TextDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonVacio_Click(object sender, EventArgs e)
        {

        }
    }
}

