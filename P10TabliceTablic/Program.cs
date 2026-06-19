using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TabliceTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablica jednowymiarowa
            string[] t1d = new string[3];

            // tablica dwuwymiarowa
            string[,] t2d = new string[3, 4];

            // tablica tablic
            string[][] tTab = new string[3][];

            //Wpisywanie/odczytwanie danych z/do tablicy tablic
            tTab[1] = new string[5];
            tTab[1][1] = "Ala";

            tTab[0] = new string[3];
            tTab[0][2] = "Ola";
            Console.WriteLine(tTab[0][1]);
            Console.WriteLine(tTab[1][2]);
        }
    }
}
