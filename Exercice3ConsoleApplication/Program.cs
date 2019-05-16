using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix;
            Console.WriteLine("Taper 1 pour un carré et 2 pour un rectable ");
            choix = Console.ReadLine();
            while (choix != "1" && choix != "2")
            {
              

                if (choix == "1")
                {
                    Console.WriteLine("Veuillez saisir un coté du carré");
                    Double cote = double.Parse(Console.ReadLine());
                    Double surface = cote * cote;
                    Console.WriteLine("La surface du carré est de" + surface);
                }
                else if (choix == "2")
                {
                    Console.WriteLine("Veuillez saisir une longueur");
                    Double longueur = double.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez saisir une largeur");
                    Double largeur = double.Parse(Console.ReadLine());
                    Double surface = longueur * largeur;
                    Console.WriteLine("La surface du rectangle est " + surface);
                    Double perimetre = (longueur + largeur) * 2;
                    Console.WriteLine("Le périmetre du rectangle est " + perimetre);
                }
                else
                {
                    Console.WriteLine("Taper 1 pour un carré et 2 pour un rectable ");
                    choix = Console.ReadLine();
                }
            }

            
            Console.ReadKey();

        }
    }
}
