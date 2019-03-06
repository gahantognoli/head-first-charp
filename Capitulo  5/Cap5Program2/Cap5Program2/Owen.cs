using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap5Program2
{
    class Owen
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank your for returning my jewels " + safeContents.Sparkle());
        }
    }
}
