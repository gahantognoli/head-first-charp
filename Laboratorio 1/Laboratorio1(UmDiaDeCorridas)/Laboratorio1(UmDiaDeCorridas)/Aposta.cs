using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio1_UmDiaDeCorridas_
{
    public class Aposta
    {
        public int Quantia;
        public int Cao;
        public Apostador Apostador;

        public string getDescricao()
        {
            if (this.Quantia == 0)
            {
                return Apostador.Name + " não apostou ";
            }
            return Apostador.Name + " apostou " + this.Quantia + " reais no cão " + this.Cao; 
        }

        public int RetirarPagamento(int ganhador)
        {
            if (this.Cao == ganhador)
            {
                return this.Quantia;
            }
            else
            {
                return -this.Quantia;
            }
        }
    }
}
