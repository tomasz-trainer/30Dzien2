using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ListaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> listaList = new List<List<string>>();
            listaList.Add(new List<string>());
            listaList.Add(new List<string>());

            listaList[0].Add("Ala");
            listaList[1].Add("Ola");

            List<string[]> listaTablic;
            List<string>[] tablicaList;

            // konwersje
            List<string> zwyklaLista = new List<string>();
            string[] zwyklaTablica = zwyklaLista.ToArray();

            zwyklaLista = zwyklaTablica.ToList();

            // Inne typyt kolekcji
            HashSet<string> zbior = new HashSet<string>();
            Dictionary<string, string> slownik = new Dictionary<string, string>();
            Queue<string> kolejka = new Queue<string>();
            Stack<string> stos = new Stack<string>();
        }
    }
}
