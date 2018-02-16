using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SysUczace
{
    class Dane
    {
        private int iloscWierszy;
        private int iloscKolumn;
        public string[,] dane;

        public Dane(string sciezkaPliku, char separator, bool czyUsunacNazwe)
        {
            string[] wiersze = File.ReadAllLines(sciezkaPliku);
            string[] atrybutyObiektu;
            this.iloscWierszy = wiersze.Length;
            this.iloscKolumn = File.ReadLines(sciezkaPliku).First().Count(x => x == separator) + 1;
            if (czyUsunacNazwe) iloscKolumn--;
            this.dane = new string[this.iloscWierszy, this.iloscKolumn];
            for (int i = 0; i < wiersze.Length; i++)
            {
                atrybutyObiektu = wiersze[i].Split(separator);
                for (int j = 0; j < this.iloscKolumn; j++) 
                    this.dane[i, j] = czyUsunacNazwe ? atrybutyObiektu[j + 1] : atrybutyObiektu[j];
            }
        }
    }
}
