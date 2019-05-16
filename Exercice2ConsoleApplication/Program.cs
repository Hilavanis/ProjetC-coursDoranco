using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double TVA = 19 / 100d; //utilisation d'un suffixe pour "forcer" l'affectation au type decimal 
            Console.WriteLine("Veuillez saisir un nom de produit");
            string produit = Console.ReadLine();
            Console.WriteLine("Veuillez entrez un prix hors taxe");
            double prixHT = Convert.ToDouble(Console.ReadLine());
            double prixTTC = prixHT * (1 + TVA); //calcule du prix TTC 
            Console.WriteLine("Le prix du {0} est de {1} euros", produit, prixTTC);
            Console.ReadKey();
        }
    }
}
