using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol2
{
    internal class Tahac : NakladniAuto
    {
        private short nosnostVlecky;
        public Tahac(string spz,short nosnost, short nosnostvlecky):base(spz, nosnost) 
        {
            nosnostVlecky = nosnostvlecky;
            nosnost += nosnostVlecky;
        }

        public short Vrat()
        { return nosnost; }

    }
}
