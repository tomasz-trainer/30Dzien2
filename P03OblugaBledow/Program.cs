using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OblugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 0;

            string s = "ala";
             
            try
            {
                string s1 = s.Substring(3, 1);
                int c = a / b;
                //.inny blad

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("wyjscie poza zakres tablicy");
                File.AppendAllText("c:\\dane\\errorlog.txt",
                    Environment.NewLine + DateTime.Now + " " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("nie dziel przez 0");
                File.AppendAllText("c:\\dane\\errorlog.txt", ex.Message);
            }
            catch (Exception ex) // przechwycenie wszystkich innych wyjatkow
            {
                Console.WriteLine("inny blad");
                File.AppendAllText("c:\\dane\\errorlog.txt", ex.Message);
            }


        }
    }
}
