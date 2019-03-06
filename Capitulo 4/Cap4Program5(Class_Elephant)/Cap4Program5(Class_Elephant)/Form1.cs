using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap4Program5_Class_Elephant_
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant Liody;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
            Liody = new Elephant() { EarSize = 40, Name = "Liody" };
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liody.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = Liody;
            Liody = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects Swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liody.TeelMe("Hi", lucinda);
            Liody = lucinda;
            Liody.EarSize = 4321;
            Liody.WhoAmI();
        }
    }
}
