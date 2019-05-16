using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6ApplicationConsole
{
    class Personne
    {
        private string nom;
        //public String Nom { get; set; }
        private string prenom;
        //public String Prenom { get; set; }
        private DateTime dateDeNaissance;
        //public String DateDeNaissance { get; set; }

        public Personne()
        {

        }

        /* public Personne () //Un constructeur vide 
         {

         }
         ==> Personne p1 = new Personne();
             */


        public Personne(string nom, string prenom, DateTime dateDeNaissance) //Un constructeur personnalisé 
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
        }

        public virtual void Affichage()
        {
            Console.WriteLine($"{nom} {prenom} est né(e) le {dateDeNaissance}");
        }


    }

    class Employe : Personne //Hérite de personne 
    {
        private double salaire;

        public Employe() : base()
        {

        }

        public Employe(string nom, string prenom, DateTime dateDeNaissance, double salaire) : base(nom, prenom, dateDeNaissance) //Un constructeur personnalisé 
        {
            this.salaire = salaire;
        }

        public override void Affichage()
        {
            base.Affichage();
            Console.WriteLine($"Je gagne {salaire} euros");
        }
    }

    class Chef : Employe //Hérite d'employé 
    {
        private string service;

        public Chef(string nom, string prenom, DateTime dateDeNaissance, double salaire, string service) : base(nom, prenom, dateDeNaissance, salaire) //Un constructeur personnalisé 
        {
            this.service = service;
        }

        public override void Affichage()
        {
            base.Affichage();
            Console.WriteLine($"Je suis dans le service {service}");
        }
    }

    class Directeur : Chef //Hérite de chef 
    {
        private string societe;

        public Directeur(string nom, string prenom, DateTime dateDeNaissance, double salaire, string service, string societe) : base(nom, prenom, dateDeNaissance, salaire, service) //Un constructeur personnalisé 
        {
            this.societe = societe;
        }
        public override void Affichage()
        {
            base.Affichage();
            Console.WriteLine($"Je suis le directeur de la société {societe}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Personne[] p;
            p = new Personne[8];

            p[0] = new Employe("NOMEDE", "Nydia", new DateTime(2018,01,01), 15000);
            p[1] = new Employe("MIHINDOU", "Sangui", new DateTime(2018, 01, 02), 15000);
            p[2] = new Employe("SEMAAN", "Rima", new DateTime(2008, 01, 01), 15000);
            p[3] = new Employe("EID", "Mais", new DateTime(2018, 01, 01), 15000);
            p[4] = new Employe("FORTUNE", "Jeoffray", new DateTime(2018, 01, 01), 15000);
            p[5] = new Chef("COULIBALY", "Gaoussou", new DateTime(2018, 01, 01), 20000, "comptabilité");
            p[6] = new Chef("BOUVEAU", "Gabriel", new DateTime(2018, 01, 02), 15000, "communication");
            p[7] = new Directeur("NELLER", "Jimmy", new DateTime(2018, 01, 02), 15000, "communication", "dorancoservice");

           /* for (int i = 0; i<p.Length; i++)
            {
                p[i].Affichage();
                Console.WriteLine("\n");
            }*/

            foreach (Personne pe in p)
            {
                pe.Affichage();
                Console.WriteLine("\n");
            }



            /* employe1.Affichage();
             Console.WriteLine("\n");
             employe2.Affichage();
             Console.WriteLine("\n");
             employe3.Affichage();
             Console.WriteLine("\n");
             employe4.Affichage();
             Console.WriteLine("\n");
             employe5.Affichage();
             Console.WriteLine("\n");


             chef1.Affichage();
             Console.WriteLine("\n");
             chef2.Affichage();
             Console.WriteLine("\n");


             directeur.Affichage();
             Console.WriteLine("\n");*/

            Console.ReadKey();
        }
    }
}
