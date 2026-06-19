using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazwisko;

            string naziwsko= "ala";

            string miasto1 = "Warszawa";
            string miasto2 = "Kraków";
            string miasto3 = "Gdańsk";

            string[] miasta = new string[4];

            miasta[0] = miasto1;
            miasta[1] = miasto2;
            //...
            miasta[3] = "Łódź";

            int dlugoscTablicy = miasta.Length;

            Console.WriteLine(miasta[0]); // Warszawa

        //    string imie = "ala";
        //    char x = imie[3];

            Console.WriteLine(miasta[2]); // Warszawa

            

            int[] temperatury = new int[2];

            string imie = "Ala";


            WebClient wc = new WebClient();
            string s= wc.DownloadString("https://www.onet.pl");


            string s2= new WebClient().DownloadString("https://www.onet.pl");


            // domyślna wartość klas to null
            // domyślna wartość struktur to 0, false, (w zależności od typu inna)
            bool[] tablicaBool = new bool[3];

            string s0 = null;
            int? x0 = null;

            int?[] temperatury2= new int?[3];
            temperatury2[1] = 10;


            // inne sposoby tworzenia tablic

            int[] liczby1 = new int[5] { 1, 2, 3, 4, 5 }; // tabica od razu uzupełniona
            int[] liczby2 = new int[] { 1, 2, 3, 4, 5 }; // tabica od razu uzupełniona
            int[] liczby3 =  { 1, 2, 3, 4, 5 }; // tabica od razu uzupełniona

            bool[] tablicaWartosciLgoczinych = { true, false, true, false };

            char[] znaki = { 'a', 'b', 'c', 'd' };


        }

        }
    }
}
