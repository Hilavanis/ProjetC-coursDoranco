using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationConsole
{
    class EtreHumain
    {

        int age;
        short anneDeNaisance;
    }

    struct Insecte
    {
        public string couleur;
        public int taille;
    }

    class Program
    {
      
        static void Main(string[] args)
        {
            EtreHumain ami = new EtreHumain(); //Instanciation 
            Insecte araignee = new Insecte
            {
                couleur = "gris",
                taille = 3
            };
            string chemin1 = "C:\\Windows\\" +
                "Desktop\\";


            
            string nom = "Noemi et \"Nydia\"";

            string remarque = $"votre identité {nom}";
            //équivalent  à 
            //string remarque = "votre identité " + nom;

            string chemin = @"C:\Windows\Desktop\";
            string chemin2 = $@"C:\Windows\Desktop\{nom}";



            // StringBuilder nom = new StringBuilder("Nydia"); //Faire une déclaration
            // nom = (StringBuilder)"Pascal"; //Faire une initialisation 

            // nom = "Noemi"; //Faire une affectation 
            // nom = nom.Replace(St"Nydia", "Pascal");

            Console.WriteLine("Attention affiche moi " + chemin2); //Concatenation

            Console.ReadKey();




           
        }
    }

   

}
