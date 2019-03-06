using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap5Program2
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;

        override public void ReturnedContents(Jewels safeContents, Owen owen)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
        
    }
}
