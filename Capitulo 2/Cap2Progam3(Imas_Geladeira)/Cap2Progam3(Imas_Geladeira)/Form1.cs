using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap2Progam3_Imas_Geladeira_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string result = "";
            int x = 3;


            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                x = x - 1;
                result = result + "-";

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }

            }
            MessageBox.Show(result);
        }
    }
}
