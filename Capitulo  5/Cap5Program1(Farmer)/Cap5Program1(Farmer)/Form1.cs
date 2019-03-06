using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap5Program1_Farmer_
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eu preciso {0} sacos de comida para {1} vacas", farmer.BagsOfFeed, farmer.NumberOfCows);
        }


    }
}
