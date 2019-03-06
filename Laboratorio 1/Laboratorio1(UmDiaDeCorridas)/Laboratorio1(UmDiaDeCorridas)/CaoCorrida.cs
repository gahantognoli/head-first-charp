using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Laboratorio1_UmDiaDeCorridas_
{
    class CaoCorrida
    {
        public int PosicaoInicial;
        public int TamanhoPista;
        public PictureBox MinhaPictureBox;
        public int Localizacao = 0;
        public Random Randomizer;

        public bool Correr()
        {
            Randomizer = new Random();
            int distandiaPercorrida = Randomizer.Next(4);
            Point p = MinhaPictureBox.Location;
            p.X += distandiaPercorrida;
            MinhaPictureBox.Location = p;

            if (p.X >= (TamanhoPista - this.MinhaPictureBox.Size.Width))
            {
                return true;
            }
            return false;
        }

        public void VoltaPosicaoInicial()
        {
            Point p = this.MinhaPictureBox.Location;
            p.X = PosicaoInicial;
            this.MinhaPictureBox.Location = p;
        }
    }
}
