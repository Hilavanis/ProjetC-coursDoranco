using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7ApplicationConsole
{

    //Une classe abstraite peut ou non contenir des méthodes abstraites 
    //Une classe abstraite oblige la classe à avoir des classes filles/dérivées
    //car une classe abstraite ne peut pas être instanciée 

    abstract class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Matricule { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Employe(string nom, string prenom, string matricule, DateTime dateDeNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Matricule = matricule;
            this.DateDeNaissance = dateDeNaissance;
        }

        public virtual string Affichage()
        {
            double salaire = this.GetSalaire();
            return $"Matricule : {Matricule} Nom : {Nom}  Prenom {Prenom} Date de naissance : {DateDeNaissance} Samlaire : {salaire}";
        }

        /*Une méthode abstraite doit se trouver obligatoirement dans une classe abstraite */
        public abstract double GetSalaire();

    }

    class Ouvrier : Employe
    {
        public DateTime DateEntree
        {
            get; set;
        }

        public static double SMIC = 1184.93d; 
        public Ouvrier(string nom, string prenom, string matricule, DateTime dateDeNaissance, DateTime dateEntree) :base(nom, prenom, matricule, dateDeNaissance)
        {
            this.DateEntree = dateEntree;
        }

        public override double GetSalaire()
        {
            double anciennete = DateTime.Now.Year - DateEntree.Year;
            double salaire = SMIC + (anciennete * 100);
            if (salaire > SMIC * 2)
            {
                return SMIC * 2;
            }
            return salaire;
        }

        public override string Affichage()
        {

            return  $" L'ouvrier {base.Affichage()} est entré(e) le : {DateEntree}";
        }
    }

    class Cadre : Employe
    {
        public int Indice
        {
            get; set;
        }
        public Cadre(string nom, string prenom, string matricule, DateTime dateDeNaissance, int indice) : base(nom, prenom, matricule, dateDeNaissance)
        {
            this.Indice = indice;
        }

        public override double GetSalaire()
        {
            double salaire=0d;

            switch (Indice)
            {
                case 1:
                    salaire = 1500;
                    break;
                case 2:
                    salaire = 1800;
                    break;
                case 3:
                    salaire = 2000;
                    break;
                case 4:
                    salaire = 2200;
                    break;
                default:
                    Console.WriteLine("Vous êtes hors catégorie");
                    break;
            }
            return salaire;
        }

        public override string Affichage()
        {

            return $" Le cadre {base.Affichage()} a un indice de : {Indice}";
        }
    }

    class Patron : Employe
    {
        public double ChiffreAffaire
        {
            get; set;
        }
        public double Pourcentage
        {
            get; set;
        }

        public Patron(string nom, string prenom, string matricule, DateTime dateDeNaissance, double chiffreAffaire, double pourcentage) : base(nom, prenom, matricule, dateDeNaissance)
        {
            this.ChiffreAffaire = chiffreAffaire;
            this.Pourcentage = pourcentage;
        }
    

        public override double GetSalaire()
        {
            // Salaire = CA * pourcentage / 100
            double salaire;
            salaire = ((ChiffreAffaire * Pourcentage) / 100)/12;
            return salaire;
        }

        public override string Affichage()
        {

            return $" Le patron {base.Affichage()} est un chiffre d'affaire de : {ChiffreAffaire} car son pourcentage est de {Pourcentage}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employe[] e;
            e = new Employe[8];

           
            e[0] = new Ouvrier("NOMEDE", "Nydia", "123456",  new DateTime(2018, 01, 01), new DateTime(2018, 01, 01));
            e[1] = new Cadre("MIHINDOU", "Sangui", "123456", new DateTime(2018, 01, 02), 15000);
            e[2] = new Patron("SEMAAN", "Rima", "123456", new DateTime(2008, 01, 01), 15000, 12);
          
            /* for (int i = 0; i<p.Length; i++)
             {
                 p[i].Affichage();
                 Console.WriteLine("\n");
             }*/

            foreach (Employe pe in e)
            {
               string message = pe.Affichage();
                Console.WriteLine($"{message}\n");
            }

        }
    }
}
