using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap4Program6_Lanchonete_SloppyJoes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            label1.Text = menu.GetmenuItem();
            label2.Text = menu.GetmenuItem();
            label3.Text = menu.GetmenuItem();
            label4.Text = menu.GetmenuItem();
            label5.Text = menu.GetmenuItem();
            label6.Text = menu.GetmenuItem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
