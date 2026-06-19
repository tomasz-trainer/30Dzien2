using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P05Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablice maja stala długość 

            string[] tablicaMiast = { "Warszawa", "Kraków", "Gdańsk" };

            // listy maja zmienną długość

            List<string> listaMiast2=null;

            List<string> listaMiast = new List<string>();  // ta lista ma 0 elementow 

            if(listaMiast == null)
            {
                // ta lista nie jest pusta ! 
            }

            listaMiast.Add("Warszawa");
            listaMiast.Add("Kraków");
            listaMiast.Insert(1, "Gdańsk"); // wstawia element na pozycję 1, a pozostałe przesuwa o 1 w prawo)

            listaMiast.Insert(4, "Wroclaw"); // wyjscie poza zakres listy - rzuci wyjątek

            string miasto1 = listaMiast[0]; // odczyt elementu o indeksie 0
            string miastOstateni = listaMiast[listaMiast.Count-1];

            listaMiast.RemoveAt(1); // usunięcie elementu o indeksie 1
            listaMiast.Remove("Kraków"); // usunięcie pierwszego wystąpienia elementu o wartości "Kraków"

        }
    }
}
