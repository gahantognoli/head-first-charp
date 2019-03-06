using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap4Program7_BiggestEars_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elephant[] Elephant = new Elephant[7];

            Elephant[0] = new Elephant(){ Name = "Lyoid", EarSize = 40 };
            Elephant[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            Elephant[3] = new Elephant() { Name = "Lucille", EarSize = 32};
            Elephant[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            Elephant[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            Elephant[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

            Elephant biggestEars = Elephant[0];
            for (int i = 1; i < Elephant.Length; i++ )
            {
                if (Elephant[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = Elephant[i];
                }
            }

            MessageBox.Show("A maior orealha é do elefante: " + biggestEars.Name + " com " + 
                            biggestEars.EarSize.ToString());
        }

    }
}
