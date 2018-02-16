using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SysUczace
{
    class Plik
    {
        string sciezka;
        public StreamReader plik;

        public Plik(string sciezka) 
        {
            this.sciezka = sciezka;
            try 
            {
                this.plik = new System.IO.StreamReader(sciezka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
