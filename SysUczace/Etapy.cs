using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysUczace
{
    class Etapy
    {
        public bool czyPlikWybrany;
        public bool czyWczytanoDane;
        public bool czyUsunacNazwe;
        public bool czyZbudowanoDrzewo;

        public Etapy() 
        {
            this.czyPlikWybrany = false;
            this.czyWczytanoDane = false;
            this.czyUsunacNazwe = false;
            this.czyZbudowanoDrzewo = false;
        }

        public void WczytaniePliku() 
        {
            this.czyWczytanoDane = false;
            this.czyUsunacNazwe = false;
            this.czyZbudowanoDrzewo = false;
        }
    }
}
