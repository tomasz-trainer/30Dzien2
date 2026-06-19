using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string strona = new WebClient().DownloadString("https://tomaszles.pl/contact");
            //File.WriteAllText("c:\\dane\\test.html", strona);
            string path = "C:\\dane\\miasta.txt";

            int wiersze = File.ReadAllLines(path).Length;

            string[] miasta = new string[wiersze];

            int i = 0;

            foreach (string linia in File.ReadAllLines(path))
            {
                miasta[i] = linia;
                Console.WriteLine($"[{i + 1}] {miasta[i]}");
                i++;
            }


            string tekst = "ala \"ma\" kota i\tpsa\noraz rybki";
            Console.WriteLine(tekst);
        }
    }
}
