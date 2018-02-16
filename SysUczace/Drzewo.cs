using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysUczace
{
    class Drzewo
    {
        string[,] daneD;
        public List<Wezel> wezly = new List<Wezel>();

        public Drzewo(string[,] dane) 
        {
            this.daneD = dane;
        }

        public void BudujDrzewo(string[,] dane, int idWezlaNadrzednego)
        {
            // brak obiektów (koniec budowania drzewa)
            if (dane.GetLength(0) == 0)
                return;
            // wszystkie obiekty mają tą samej klasy decyzyjnej (tworzenie liścia / decyzji)
            else if (Metody.Entropia(dane, dane.GetLength(1) - 1) == 0)
            {
                wezly.Add(new Wezel(idWezlaNadrzednego, typ.decyzja, dane[0, dane.GetLength(1) - 1].ToString()));
                return;
            }
            else
            {
                List<double> gainRatios = new List<double>();
                for (int i = 0; i < dane.GetLength(1) - 1; i++)
                    gainRatios.Add(Metody.GainRatio(dane, i));
                int maxGainAt = gainRatios.IndexOf(gainRatios.Max());
                if (gainRatios.Max() == 0)
                {
                    // dane są sprzeczne to decyzja jest losowa
                    wezly.Add(new Wezel(idWezlaNadrzednego, typ.decyzja, dane[0, dane.GetLength(1) - 1].ToString()));
                    return;
                }
                Wezel w = new Wezel(idWezlaNadrzednego, typ.atrybut, maxGainAt.ToString());
                wezly.Add(w);
                string[] wybranaKolumna = Metody.Kolumna(dane, maxGainAt);
                List<string> mozliwosci = wybranaKolumna.Distinct().ToList();
                for (int i = 0; i < mozliwosci.Count; i++)
                {
                    Wezel wDziecko = new Wezel(w.id, typ.wartosc, mozliwosci[i].ToString());
                    wezly.Add(wDziecko);
                    BudujDrzewo(Metody.NowaTabela(dane, maxGainAt, mozliwosci[i]), wDziecko.id);
                }
            }
            return;
        }

        public void RysujDrzewo(int idOjca, List<Wezel> wezly, int glebokosc, ref string struktura) 
        {
            foreach (Wezel w in wezly)
                if (w.idOjca == idOjca)
                {
                    struktura += w.RysujWezel(glebokosc + 1);
                    RysujDrzewo(w.id, wezly, glebokosc + 1, ref struktura);
                }        
        } 
    }
}
