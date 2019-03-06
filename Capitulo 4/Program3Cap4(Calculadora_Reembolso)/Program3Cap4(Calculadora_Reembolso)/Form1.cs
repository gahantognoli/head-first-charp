using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * ------------------------------------ PROGRAMA CALCULO DE REEMBOLSO -------------------------------------
 */
namespace Program3Cap4_Calculadora_Reembolso_
{
    public partial class Reembolso : Form
    {
        int quilometragemInicial;
        int quilometragemFinal;
        double quilometragemPercorrida;
        double quantiaReembolso = .39;
        double valorReembolsado;

        public Reembolso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reembolso_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            quilometragemInicial = (int)numericQuilometragemInicial.Value;
            quilometragemFinal = (int) numericQuilometragemFinal.Value;
            if (quilometragemInicial < quilometragemFinal)
            {
                quilometragemPercorrida = quilometragemFinal - quilometragemInicial;
                valorReembolsado = quilometragemPercorrida * quantiaReembolso;
                lblReembolso.Text = "$" + valorReembolsado;

            }
            else
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a quilometragem final", "Impossível Calcular");
            }
        }

        private void btnMostraQuilometragem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(quilometragemPercorrida + " Quilometros", "Quilometros percorritos");
        }
    }
}
