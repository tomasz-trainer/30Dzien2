using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P04onwersjaTablicOrazNapisow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "Ala ma  kota";

            // SPLIT - rozdziela napis na części, zwracając tablicę

            string[] wyrazy = zdanie.Split(' ');

            string zdanie2 = "Ala!$ma**kota";

            string[] separatory = { "!$","**" };

            string[] wyrazy2 = zdanie2.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(wyrazy2[0] + " " + wyrazy[1]);

            // join - łączy elementy tablicy w jeden napis

            string[] wyrazy3 = { "Ala", "ma", "kota" };

            string wynik = string.Join(" - ", wyrazy3);
            Console.WriteLine(wynik);


        }
    }
}
