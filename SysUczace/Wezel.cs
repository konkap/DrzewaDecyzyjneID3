using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysUczace
{
    public enum typ { atrybut, wartosc, decyzja };

    public class Wezel
    {
        private static int licznikID = 0;
        public int id;
        public int idOjca;
        public typ rodzaj;
        string wartosc;

        public Wezel(int idOjca, typ rodzaj, string wartosc)
        {
            this.id = System.Threading.Interlocked.Increment(ref licznikID);
            this.idOjca = idOjca;
            this.rodzaj = rodzaj;
            this.wartosc = wartosc;
        }

        public string RysujWezel(int glebokosc)
        {
            string odstep = "";
            for (int i = 0; i < glebokosc; i++)
                odstep += "|   ";
            if (this.rodzaj == typ.atrybut)
                return String.Format("\n{0}A({1})", odstep, this.wartosc);
            else if (this.rodzaj == typ.wartosc)
                return String.Format("\n{0}W({1})", odstep, this.wartosc);
            else
                return ": " + this.wartosc;
        }
    }
}
