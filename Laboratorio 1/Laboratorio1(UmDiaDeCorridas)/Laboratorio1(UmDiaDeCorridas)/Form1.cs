using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio1_UmDiaDeCorridas_
{
    public partial class Form1 : Form
    {
        Apostador[] apostadores;
        CaoCorrida[] caes;

        public Form1()
        {

            InitializeComponent();

            int tamPista = PistaCorrida.Size.Width;
            apostadores = new Apostador[3];

            apostadores[0] = new Apostador();
            apostadores[0].Name = "Bob";
            apostadores[0].Dinheiro = 75;
            apostadores[0].meuRadioButton = radioButtonBob;
            apostadores[0].minhaLabel = lblApostaBob; 
            
            /*
            apostadores[1] = new Apostador()
            {
                Name = "Joe",
                Dinheiro = 50,
                meuRadioButton = radioButtonJoe,
                minhaLabel = lblApostaJoe
            };

            apostadores[2] = new Apostador() 
            { 
                Name = "Al",
                Dinheiro = 45,
                meuRadioButton = radioButtonAl,
                minhaLabel = lblApostaAl
            };

             * */
            caes = new CaoCorrida[4];

            caes[0] = new CaoCorrida()
            {
                MinhaPictureBox = pictureBox2,
                TamanhoPista = tamPista
            };

            caes[1] = new CaoCorrida()
            {
                MinhaPictureBox = pictureBox3,
                TamanhoPista = tamPista
            };

            caes[2] = new CaoCorrida()
            {
                MinhaPictureBox = pictureBox4,
                TamanhoPista = tamPista
            };

            caes[3] = new CaoCorrida()
            {
                MinhaPictureBox = pictureBox5,
                TamanhoPista = tamPista
            };

            foreach (Apostador apostador in apostadores)
            {
                apostador.AtualizaCampos();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PistaCorrida_Click(object sender, EventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        

    } 
}
