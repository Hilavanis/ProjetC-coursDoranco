using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApplicationConsole
{

    public class Personne
    {
        /*****Les propriétés******/ 
      
        public string prenom;
        public DateTime dateDeNaissance;
        public short taille;

        
        /**Première solution**/
        // public string nom;

        /**Deuxieme solution**/
        /* public string Nom
          {
              get
              {
                  return Nom;
              }
              set
              {
                  Nom = value;
              }
          }*/
        /**Troisieme solution simplifiée **/
        public string Nom { get; set; } = "NOMEDE";

        //Constructeur vide
        public Personne()
        {
            this.prenom = "Nydia";
            taille = 162;

        }

        public Personne(string prenom, string nom)
        {
            this.prenom = prenom;
            this.Nom = nom;
            taille = 162;

        }

        // private TimeSpan heure = new TimeSpan(8, 0, 0);

        /*****Les méthodes******/
        public TimeSpan SeLeverLeMatin(TimeSpan heure, int nbre = 5) //une méthode qui ne retourne rien se nomme une procédure
        {
            Console.WriteLine($"{nbre} fois par semaine");
            return heure;
        }

    }

    interface IFemme
    {
        void accouche(string nom);
        void allaiter(DateTime heure);
    }

    class Employe : Personne,IFemme //Hérite de personne 
    {

        public string nomEnfant; 

        public void accouche(string nom)
        {
            Console.WriteLine($"J'ai accouché,  mon enfant s'appelle {nom}");

        }  

        public void allaiter(DateTime heure)
        {
            Console.WriteLine($"J'allaite à {heure}");
        }
    }

    public class Femme : Personne
    {
        public bool Naissance { get; set; }
    }
    public class Homme : Personne
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

            Femme stagiaire1 = new Femme();  //instanciation d'un nouvel objet
            /**Définir l'état d'un objet***/
            stagiaire1.Nom = "Nomede";
            // stagiaire1.prenom = "Gabriel";
            stagiaire1.Naissance = true;

            stagiaire1.dateDeNaissance = new DateTime(2018,01,10);
           // stagiaire1.taille = 190;
            
            /**Définir le comportement d'un objet***/
            TimeSpan heure1 = stagiaire1.SeLeverLeMatin(new TimeSpan(5, 0, 0));

            Console.WriteLine($"Au cours de C#, l'étudiant {stagiaire1.Nom} {stagiaire1.prenom} est présent à {heure1} et mesure {stagiaire1.taille}");

            Personne stagiaire2 = new Personne();  //instanciation d'un nouvel objet
            stagiaire2.Nom = "Vincent";
            stagiaire2.Nom = "Ravoisier";
            //stagiaire2.prenom = "Vincent";
            stagiaire2.dateDeNaissance = new DateTime(2017, 01, 10);
           // stagiaire2.taille = 180;
            TimeSpan heure2 = stagiaire2.SeLeverLeMatin(new TimeSpan(8, 0, 0));

            Console.WriteLine($"Au cours de C#, l'étudiant {stagiaire2.Nom} {stagiaire2.prenom} est présent {heure2} et mesure {stagiaire2.taille}");


            /*****Test interface *******/

            Employe employe1 = new Employe();

            employe1.accouche("nydia");
            employe1.allaiter(new DateTime(2018,02,01));

            Console.ReadKey();
        }

    }
}