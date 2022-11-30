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
        private double nosnost; 
        private double naklad;

        public double HmotnostNakladu { get; }

        public NakladniAuto(string spz, double nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(double naklad2)
        {
            this.naklad = naklad2;
            if(naklad > nosnost)
            {
                MessageBox.Show("nebylo nalozeno: " + (naklad - nosnost) + " tun");
                naklad = nosnost;
            }
            else
            {
                MessageBox.Show("bylo nalozeno: " + naklad + " tun");
            }
        }

        public void VylozNaklad(double vylozit)
        {
            if(vylozit > naklad)
            {
                MessageBox.Show("Bylo maximalne vylozeno " + naklad + " tun chybi vylozit "+(vylozit - naklad) + " tun");
            }else MessageBox.Show("Bylo vylozeno " + vylozit +" tun");
        }

        public override string ToString()
        {
            return String.Format("Nákladní auto {0} má nosnost {1} tun a má naloženo {2} tun", spz, nosnost, naklad);
        }
    }
}
