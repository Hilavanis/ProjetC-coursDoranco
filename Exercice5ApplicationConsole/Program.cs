using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entrez un nombre");
                int value = int.Parse(Console.ReadLine());
                if (value > 0)
                    Console.WriteLine($"|{value}| = {value}");
                else
                    Console.WriteLine($"|{value}| = {Math.Abs(value)}");
                   
                Console.WriteLine($"|{value}| = "+(value>0 ? value : Math.Abs(value)));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("saisie incorrecte");
            }
            finally
            {

            }
            Console.ReadKey();
        }
    }
}
