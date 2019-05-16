using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice8BienEntrepriseApplicationConsole;

namespace Exercice8VehiculeApplicationConsole
{
    abstract class Vehicule : IBienEntreprise
    {
        // public int Matricule { get;  }
        private int matricule;
        private int anneModele;
        private double prix;
        static int nbreVehiculeCree = 0;

        public Vehicule(int anneModele, double prix, bool EstDeclare)
        {
            nbreVehiculeCree++; //nbreVehiculeCree = nbreVehiculeCree++;  +1

            this.matricule = nbreVehiculeCree;
            this.anneModele = anneModele;
            this.prix = prix;
            this.EstDeclare = EstDeclare;
        }

        public bool EstDeclare { get; set; }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public virtual string Affichage()
        {
            return $" Matricule : {matricule} Annee : {anneModele} Prix : {prix}  EstDeclare : {EstDeclare}";

            
        }
    }

    class Voiture : Vehicule {
        public Voiture(int anneModele, double prix, bool EstDeclare) :base(anneModele, prix, EstDeclare) { }

        public override void Demarrer()
        {
            Console.WriteLine("La voiture démarre...");
        }

        public override void Accelerer()
        {
            Console.WriteLine("La voiture accélère...");
        }

        public override string Affichage()
        {
            return $" Voiture : {base.Affichage()}";

        }
    }

    class Camion : Vehicule {
        public Camion(int anneModele, double prix, bool EstDeclare) : base(anneModele, prix, EstDeclare) { } 

        public override void Demarrer()
        {
            Console.WriteLine("Le camion démarre...");
        }

        public override void Accelerer()
        {
            Console.WriteLine("Le camion accélère...");
        }

        public override string Affichage()
        {
            return $" Camion : {base.Affichage()}";

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] v;
            v = new Vehicule[12];


            
             for (int i = 0; i<3; i++)
             {
                v[i] = new Voiture(2005, 20000, true);
                v[i].Demarrer();
                v[i].Accelerer();
                Console.WriteLine($"{v[i].Affichage()}\n");
            }           

            for (int i = 3; i < 10; i++)
            {
                v[i] = new Camion(2002, 20000, true);
                v[i].Demarrer();
                v[i].Accelerer();
                Console.WriteLine($"{v[i].Affichage()}\n");
            }
            /*

           foreach (Employe pe in e)
           {
               v[0] = new Ouvrier("NOMEDE", "Nydia", "123456", new DateTime(2018, 01, 01), new DateTime(2018, 01, 01));

               string message = pe.Affichage();
               Console.WriteLine($"{message}\n");
           }*/
            Console.ReadKey();
        }
    }
}
