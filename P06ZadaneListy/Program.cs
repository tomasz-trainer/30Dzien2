using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaneListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = "C:\\dane\\miasta.txt";

            // Wczytanie pliku do pamięci
            string[] wiersze = File.ReadAllLines(pathToFile);

            // Iniacjalizacja list do przechowywania wyników
            List<string> miasta = new List<string>();
            List<double> temperatury = new List<double>();

            // Główna pętla programu
            while (true)
            {
                // Wczytanie nazwy miasta od użytkownika
                Console.WriteLine("Proszę podać nazwę miasta:");
                string miastoWejsciowe = Console.ReadLine();

                // Przeszukiwanie kolekcji wierszy wczytanych z pliku
                foreach (var item in wiersze)
                {
                    if (item.Contains(miastoWejsciowe))
                    {
                        string[] miastoOrazTemperatura = item.Split(' ');
                        string miasto = miastoOrazTemperatura[0];
                        string temperaturaStr = miastoOrazTemperatura[1];
                        double temperatura = Convert.ToDouble(temperaturaStr);
                        Console.WriteLine($"Aktualna temperatura w {miasto} to: {temperatura}°C");
                        miasta.Add(miasto);
                        temperatury.Add(temperatura);
                        break;
                    }
                }

                // Wyświetlenie wyników
                string wynikoweMiasta = string.Join(", ", miasta);
                double srTemp = temperatury.Average();
                Console.WriteLine($"Średnia temperatura z listy ({wynikoweMiasta}) to: {srTemp}°C");
                Console.WriteLine("\n\r \n\r \n\r");
            }
        }
    }
}
