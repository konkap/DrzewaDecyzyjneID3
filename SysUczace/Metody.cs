using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysUczace
{
    static class Metody
    {
        public static int IleWystapien(string[] tablica, string wartosc)
        {
            int iloscWystapien = 0;
            foreach (string w in tablica)
                if (w == wartosc)
                    iloscWystapien++;
            return iloscWystapien;
        }

        public static Dictionary<string, int> Wystapienia(string[] tablica) 
        {
            string[] mozliwosci = tablica.Distinct().ToArray();
            Dictionary<string, int> tablicaWystapien = new Dictionary<string, int>();
            foreach (string m in mozliwosci)
                tablicaWystapien.Add(m, Metody.IleWystapien(tablica, m));
            return tablicaWystapien;
        }

        public static string[] Kolumna(string[,] tablica, int indeksKolumny)
        {
            if (indeksKolumny < 0 || indeksKolumny > tablica.GetLength(1))
                throw new Exception("Metoda [Kolumna]: Wybrano nieprawidłowy nr kolumny");
            string[] kolumna = new string[tablica.GetLength(0)];
            for (int i = 0; i < tablica.GetLength(0); i++)
                kolumna[i] = tablica[i, indeksKolumny];
            return kolumna;
        }

        public static double Entropia(string[] wartAtrybutu)
        {
            Dictionary<string, int> tabWystapien = Metody.Wystapienia(wartAtrybutu);
            double p = 0.0;
            foreach (int iloscWystapien in tabWystapien.Values)
                p += (iloscWystapien / (double)wartAtrybutu.Length)
                    * Math.Log(iloscWystapien / (double)wartAtrybutu.Length, 2);
            return -p;
        }

        public static double Entropia(string[,] tablica, int nrKolumny)
        {
            return Entropia(Metody.Kolumna(tablica, nrKolumny));
        }

        public static double Info(string[,] tablica, int nrKolumny) 
        {
            return Entropia(tablica, nrKolumny);
        }

        public static double Info2(string[,] tablica, int nrKolumny)
        {
            double suma = 0;
            string[] wartAtrybutu = Metody.Kolumna(tablica, nrKolumny);
            Dictionary<string, int> tabWystapien = Metody.Wystapienia(wartAtrybutu);
            for (int i = 0; i < tabWystapien.Count; i++)
            {
                List<string> podzial = new List<string>();
                for (int j = 0; j < wartAtrybutu.Length; j++)
                    if (wartAtrybutu[j] == tabWystapien.ElementAt(i).Key)
                        podzial.Add(tablica[j, tablica.GetLength(1) - 1]);
                suma += ((double)tabWystapien.ElementAt(i).Value / wartAtrybutu.Length) * Entropia(podzial.ToArray());
            }
            return suma;
        }

        public static double Gain(string[,] tablica, int nrAtrybutu)
        {
            return (Info(tablica, tablica.GetLength(1) - 1)) - Info2(tablica, nrAtrybutu);
        }

        public static double SplitInfo(string[,] tablica, int nrAtrybutu)
        {
            return Entropia(Metody.Kolumna(tablica, nrAtrybutu));
        }

        public static double GainRatio(string[,] tablica, int nrAtrybutu)
        {
            return Gain(tablica, nrAtrybutu) / SplitInfo(tablica, nrAtrybutu);
        }
               
        public static string[,] NowaTabela(string[,] tablica, int nrAtrybutu, string wartosc)
        {
            int iloscWierszy = Metody.IleWystapien(Metody.Kolumna(tablica,nrAtrybutu),wartosc);
            string[,] nowaTab = new string[iloscWierszy,tablica.GetLength(1)];
            int wierszNowej = 0;
            for (int i = 0; i < tablica.GetLength(0); i++) 
            {
                if (tablica[i, nrAtrybutu] == wartosc) 
                {
                    for (int j = 0; j < tablica.GetLength(1); j++)
                        nowaTab[wierszNowej, j] = tablica[i, j];
                    wierszNowej++;
                }  
            }
            return nowaTab;
        }
        
    }
}
