using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8CompteBancaireApplicationConsole
{
    class CompteEpargne : Compte
    {
        private double tauxinteret = 6;

        public double Tauxinteret { get; }
       

        public CompteEpargne() : base() { }                  //constructeur par défaut
        
        public CompteEpargne(double solde) : base(solde) { } //constructeur d'initialisation

        public void CalculerInteret()                      //une nouvelle méthode qui utilise une méthode héritée
        {
            deposer((Solde * tauxinteret) / 100);
        }

        public override string ToString()                  //redéfinition de la méthode ToString()
        {
            return "Compte Epargne: " + base.ToString() + " Taux interêt: " + tauxinteret;
        }
    }

}
