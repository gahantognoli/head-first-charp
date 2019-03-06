using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap5Program2
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owen owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnedContents(safeContents, owner);
        }

        private string writtenDownCombination = null;
        public void WhiteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        virtual public void ReturnedContents(Jewels safeContents, Owen owen)
        {
            owen.ReceiveContents(safeContents);
        }
    }
}
