using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09TablicieWielowymiaroweZadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = "C:\\dane\\zawodnicy.csv";

            // Wczytanie pliku do pamięci
            string dane = File.ReadAllText(pathToFile);

            string[] wiersze = dane.Split('\n');
            string[] naglowki = wiersze[0].Split(';');

            int iloscWierszy = wiersze.Length; 
            int iloscKolumn = naglowki.Length;

            string[,] zawodnicy = new string[iloscWierszy - 1, iloscKolumn]; // Odejmujemy 1, ponieważ pierwszy wiersz to nagłówki

            for (int i = 1; i < iloscWierszy; i++)
            {
                //  wiersze[i] -> 1;Kylian;Mbappé;Francja;75;178;1998-12-20 jako jeden string
                string[] kolumny = wiersze[i].Split(';');
                // kolumny -> ["1", "Kylian", "Mbappé", "Francja", "75", "178", "1998-12-20"]
                for (int j = 0; j < iloscKolumn; j++)
                {
                    zawodnicy[i - 1, j] = kolumny[j];
                    // zawodnicy[i - 1, j] = wiersze[i].Split(';')[j];
                }
            }

            for (int i = 0; i < zawodnicy.GetLength(0); i++)
            {
                for (int j = 0; j < zawodnicy.GetLength(1); j++)
                {
                    Console.Write(zawodnicy[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
