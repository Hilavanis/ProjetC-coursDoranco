using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votre nom ?"); 
            //Affiche "Votre nom ?"

            string nom = Console.ReadLine(); 
            //Récupère le nom entré par l'utilisateur 

            Console.WriteLine("Votre prenom ?");
            //Affiche "Votre prenom ?"

            string prenom = Console.ReadLine();
            //Récupère le prenom entré par l'utilisateur 

            Console.WriteLine("Votre date de naissance ?"); 
            //Affiche "Votre date de naissance ?"

           // int dateDeNaissance = int.Parse(Console.ReadLine()); 
           //Récupère la date de naissance et converti en int

            int dateDeNaissance = Convert.ToInt16(Console.ReadLine()); 
            //Récupère la date de naissance et converti en int

            // int age = 2016 - dateDeNaissance; 
            //Calcule l'age en partant de 2016

            int age = DateTime.Today.Year - dateDeNaissance; 
            //Calcule l'age en partant de l'année actuelle 

            Console.WriteLine("Bonjour :" + nom + "vous avez " + age +" ans"); 
            //Ecrit le resultat 

            Console.WriteLine("Bonjour : {0} {1} vous avez {2} ans", nom, prenom, age); 
            //Ecrit le resultat 

            Console.ReadKey(); //Permettre d'attendre une saisie utilisateur 


        }
    }
}
