using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio1_UmDiaDeCorridas_
{
    public class Apostador
    {
        public String Name;
        public Aposta MinhaAposta { get; set; }
        public int Dinheiro;
        public RadioButton meuRadioButton;
        public Label minhaLabel { get; set; }

        public void AtualizaCampos()
        {
            MinhaAposta = new Aposta();
            this.minhaLabel.Text = this.MinhaAposta.getDescricao();
            meuRadioButton.Text = this.Name + " tem " + this.Dinheiro + " reais.";
        }

        public void LimpaAposta()
        {
            this.MinhaAposta.Quantia = 0;
        }

        public bool FazAposta(int quantia, int cao)
        {
            if (quantia > this.Dinheiro)
            {
                return false;
            }

            MinhaAposta = new Aposta();
            MinhaAposta.Quantia = quantia;
            MinhaAposta.Cao = cao;
            MinhaAposta.Apostador = this;

            this.Dinheiro -= quantia;

            return true;
        }

        public void Coletar(int ganhador)
        {
            if (this.MinhaAposta.Cao == ganhador)
            {
                this.MinhaAposta.Quantia *= 2;
            }
        }
    }
}
