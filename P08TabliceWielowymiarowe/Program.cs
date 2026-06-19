using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja tablicy jednowymiarowej
            string[] tablica1D = new string[5];

            // Inicjalizacja tablicy dwuwymiarowej
            string[,] tablica2D = new string[3, 4];

            // Inicjalizacja tablicy trójwymiarowej
            string[,,] tablica3D = new string[2, 3, 4];

            // Inicjalizaca tablicy czworowymiarowej
            string[,,,] tablica4D = new string[2, 3, 4, 5];

            // Przykład przypisania wartości do tablicy dwuwymiarowej
            tablica2D[0, 0] = "A 1";
            tablica2D[0, 1] = "A 2";
            tablica2D[0, 2] = "A 3";
            tablica2D[0, 3] = "A 4";
            tablica2D[1, 0] = "B 1";
            tablica2D[1, 1] = "B 2";
            tablica2D[1, 2] = "B 3";
            tablica2D[1, 3] = "B 4";
            tablica2D[2, 0] = "C 1";
            tablica2D[2, 1] = "C 2";
            tablica2D[2, 2] = "C 3";
            tablica2D[2, 3] = "C 4";
            Console.WriteLine(tablica2D[0, 0]);

            // Całkowity rozmiar tablicy
            int rozmiarTablicy2D = tablica2D.Length;
            Console.WriteLine($"Rozmiar tablicy to: {rozmiarTablicy2D}");

            // Rozmiary poszczgólnych wymiarów tablicy
            int rozmiarWymiaru0 = tablica2D.GetLength(0);
            int rozmiarWymiaru1 = tablica2D.GetLength(1);
            //int rozmiarWymiaru2 = tablica2D.GetLength(2); // Nie można użyć GetLength(2) dla tablicy dwuwymiarowej, ponieważ nie ma trzeciego wymiaru
            Console.WriteLine($"Tablica ma {rozmiarWymiaru0} wierszy i {rozmiarWymiaru1} kolumn.");

            // Sprawdzenie ilości wymiarów tablicy
            int rank = tablica2D.Rank;
            Console.WriteLine($"Tablica ma {rank} wymiary.");

            // Przykład
            Console.WriteLine("Badanie rozmiarów tablict 3D");
            for (int i = 0; i < tablica3D.Rank; i++)
            {
                Console.WriteLine($"Wymiar n = {i + 1} ma rozmiar s = {tablica3D.GetLength(i)}");
            }

            // Wyświetlanie całej zawartości tablicy dwuwymiarowej
            for (int i = 0; i < tablica2D.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2D.GetLength(1); j++)
                {
                    // czy ostatniy element w wierszu? Jeśli tak, to nie dodajemy przecinka na końcu
                    // j => 0, 1, 2, 3
                    // tablica2D.GetLength(1) => 4
                    if (j == tablica2D.GetLength(1) - 1) // -1, bo indeksy zaczynają się od 0
                    {
                        Console.Write($"{tablica2D[i, j]}");
                    }
                    else
                    { 
                        Console.Write($"{tablica2D[i, j]}, "); 
                    }
                }
                Console.WriteLine();
            }

            // Test obliczeń na tabliach wielowymiarowych
            int n = 10000; // rozmiar tablicy n x n
            int[,] t = new int[n, n]; // tworzenie tablicy dwuwymiarowej o rozmiarze n x n
            int counter = 0; // licznik do wypełniania tablicy wartościami
            // Cel: wypełnienie tablicy wartościami od 0 do n*n-1
            // dla tablicy 3x3 wyglądałoby to tak:
            // 0, 1, 2
            // 3, 4, 5
            // 6, 7, 8
            for (int i = 0; i < n; i++) // pętla po wierszach
            {
                for (int j = 0; j < n; j++) // pętla po kolumnach
                {
                    t[i, j] = counter++; // przypisanie wartości do elementu tablicy i zwiększenie licznika
                }
            }
            //// Wyświetlanie tablicy t
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{t[i, j]}, ");
            //    }
            //    Console.WriteLine();
            //}

            Stopwatch st = new Stopwatch();
            // Obliczenie sumy wszystkich elementów tablicy
            int suma1 = 0; // zmienna do przechowywania sumy
            st.Start(); // rozpoczęcie pomiaru czasu
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma1 += t[i, j]; // dodanie wartości elementu tablicy do sumy
                }
            }
            double t1 = st.Elapsed.TotalSeconds;
            Console.WriteLine($"Suma wszystkich elementów tablicy t to: {suma1}"); // wyświetlenie wyniku
            Console.WriteLine($"Suma obliczona w czasie t = {t1} [ms]");

            int suma2 = 0; // zmienna do przechowywania sumy
            st.Restart(); // rozpoczęcie pomiaru czasu
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma2 += t[j, i]; // dodanie wartości elementu tablicy do sumy
                }
            }
            double t2 = st.Elapsed.TotalSeconds;
            Console.WriteLine($"Suma wszystkich elementów tablicy t to: {suma2}"); // wyświetlenie wyniku
            Console.WriteLine($"Suma obliczona w czasie t = {t2} [ms]");

        }
    }
}
