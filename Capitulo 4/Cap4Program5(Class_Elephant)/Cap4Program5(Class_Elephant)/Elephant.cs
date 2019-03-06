using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cap4Program5_Class_Elephant_
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall", Name + " says ...");
        }

        public void TeelMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }

        public void SpaekTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TeelMe(message, this);
        }
    }
}
