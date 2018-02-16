using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//2,39056

namespace SysUczace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // obiekty globalne
        Dane d;
        Etapy etapy = new Etapy();
        Drzewo t;

        // wybieranie pliku
        private void wybierzPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    toolStripStatusLabel1.Text = "Wybrano plik: " + Path.GetFileName(openFileDialog1.FileName);
                    ekranRTB.Text = "Struktura pliku wygląda następująco:\n\n"
                        + File.ReadLines(openFileDialog1.FileName).First()
                        + "\n\nWybierz separator i pobierz dane.";
                    etapy.czyPlikWybrany = true;
                    etapy.WczytaniePliku();
                    konsolaTB.Text = ",";
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Plik jest pusty");
        }

        // wczytywanie danych z pliku
        private void wczytajToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (etapy.czyPlikWybrany)
            {
                etapy.czyPlikWybrany = false;
                d = new Dane(openFileDialog1.FileName, konsolaTB.Text[0], etapy.czyUsunacNazwe);
                toolStripStatusLabel1.Text = "Wczytano dane z: " + Path.GetFileName(openFileDialog1.FileName);
                ekranRTB.Text = "Wczytano " + d.dane.GetLength(0) + " obiektów po " + d.dane.GetLength(1) + " cech.";
                konsolaTB.Text = "";
                etapy.czyWczytanoDane = true;
                konsolaTB.Text = d.dane.GetLength(1).ToString();
            }
            else 
                MessageBox.Show("Nie wybrano pliku!");
        }

        // wyświetlenie danych
        private void wyswietlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (etapy.czyWczytanoDane) 
            {
                string tabelaDane = "";
                int iloscWierszyWOknie = (d.dane.GetLength(0) < 10) ? d.dane.GetLength(1) : 10;
                for (int i = 0; i < iloscWierszyWOknie; i++)
                {
                    for (int j = 0; j < d.dane.GetLength(1); j++)
                        tabelaDane += d.dane[i, j] + "|";
                    tabelaDane += "\n";
                }
                MessageBox.Show(tabelaDane);
            }
            else
                MessageBox.Show("Nie wczytano danych!");  
        }

        // możliwość usunięcia pierwszej kolumny
        private void usun1kolumneToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            etapy.czyUsunacNazwe = etapy.czyUsunacNazwe ? false : true;
        }
  
        // budowanie drzewa
        private void budujDrzewoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (etapy.czyWczytanoDane)
            {
                t = new Drzewo(d.dane);
                t.BudujDrzewo(d.dane, 0);
                toolStripStatusLabel1.Text = "Zbudowano drzewo z danych: " + Path.GetFileName(openFileDialog1.FileName);
                etapy.czyZbudowanoDrzewo = true;
            }
            else
                MessageBox.Show("Nie wczytano danych!");   
        }
        
        // rysowanie drzewa
        private void rysujDrzewoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (etapy.czyZbudowanoDrzewo)
            {
                ekranRTB.Text = "";
                string struktura = "";
                t.RysujDrzewo(0, t.wezly, -1, ref struktura);
                ekranRTB.Text = struktura;
                toolStripStatusLabel1.Text = "Narysowano drzewo z danych: " + Path.GetFileName(openFileDialog1.FileName);
            }
            else
                MessageBox.Show("Nie zbudowano drzewa!"); 
        }

        // TESTOWANIE
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekranRTB.Text = "";
            for (int i = 0; i < d.dane.GetLength(1) - 1; i++)
            {
                ekranRTB.Text += "Kolumna " + i + " zysk: " + Metody.GainRatio(d.dane, i).ToString() + "\n";
            }
        }
    }
}
