using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol2
{
    internal class NakladniAuto
    {

        private string spz;
        private short nosnost; 

        private short hmotnostnakladu;
        public short HmotnostNakladu { get => hmotnostnakladu; }

        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(short naklad)
        {
            hmotnostnakladu += naklad;
            if (hmotnostnakladu <= nosnost)
            {
                MessageBox.Show("bylo nalozeno: " + hmotnostnakladu + " tun");
            }
            else
            {
                MessageBox.Show("nebylo nalozeno: " + (hmotnostnakladu - nosnost) + " tun");
                hmotnostnakladu = nosnost;
            }
        }

        public void VylozNaklad(short vylozit)
        {
            if (vylozit > hmotnostnakladu)
            {
                MessageBox.Show("Bylo maximalne vylozeno " + hmotnostnakladu + " tun chybi vylozit " + (vylozit - hmotnostnakladu) + " tun");
                hmotnostnakladu = 0;
            }
            else
            {
                MessageBox.Show("Bylo vylozeno " + vylozit + " tun");
                hmotnostnakladu -= vylozit;
            }
        }

        public override string ToString()
        {
            return String.Format("Nákladní auto {0} má nosnost {1} tun a má naloženo {2} tun", spz, nosnost, hmotnostnakladu);
        }
    }
}
