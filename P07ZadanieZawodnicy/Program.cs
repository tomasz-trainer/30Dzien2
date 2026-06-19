using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = "C:\\dane\\zawodnicy.csv";

            // Wczytanie pliku do pamięci
            string[] wiersze = File.ReadAllLines(pathToFile);

            // Wczytanie nazwy kraju od użytkownika
            Console.WriteLine("Proszę podać kraj:");
            string kraj = Console.ReadLine();

            // Praca domowa: zmodyfikować kod w taki sposób,
            // aby indeksy kolumny imienia i nazwiska
            // były znajdowane automatycznie
            int indexImie = 1;
            int indexNazwisko = 2;
            char separator = ';';
            List<string> zawodnicyDanegoKraju = new List<string>();
            foreach (var zawodnik in wiersze)
            {
                if (zawodnik.Contains(kraj))
                {
                    string[] daneZawodnika = zawodnik.Split(separator);
                    string imieNazwisko = $"{daneZawodnika[indexImie]} {daneZawodnika[indexNazwisko]}";
                    zawodnicyDanegoKraju.Add(imieNazwisko);
                }
            }

            string sciezkaFolderuWyjsciowego = $"C:\\dane\\kraje";
            if (!Directory.Exists(sciezkaFolderuWyjsciowego))
            {
                Directory.CreateDirectory(sciezkaFolderuWyjsciowego);
            }

            string sciezkaPlikuWyjsciowego = sciezkaFolderuWyjsciowego + $"\\{kraj}.txt";
            if (!File.Exists(sciezkaPlikuWyjsciowego))
            {
                File.WriteAllLines(sciezkaPlikuWyjsciowego, zawodnicyDanegoKraju);
            }
        }
    }
}
