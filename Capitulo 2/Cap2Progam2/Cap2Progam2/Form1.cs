using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap2Progam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //isto é um comentário
            string name = "Gabriel";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("Nome é: " + name +
                            "\n x: " + x +
                            "\n d: " + d
                            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X é igual a 10");
            }
            else
            {
                MessageBox.Show("X não é igual a 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 3;
            string name = "Bobbo Jr.";

            if ((someValue == 3) && (name == "Joe"))
            {
                MessageBox.Show("x is 3 and the name is Joe");
            }
            MessageBox.Show("This line runs no matter what!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            MessageBox.Show("The answer is: " + count);
        }
    }
}
