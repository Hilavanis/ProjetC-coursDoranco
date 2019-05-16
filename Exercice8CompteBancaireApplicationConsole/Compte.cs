using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassApplicationConsole;


namespace Exercice8CompteBancaireApplicationConsole
{
    class Compte
    {
        private int code;
        private double solde;
        private static int nb_comptes = 0;

        public int Code { get; }

        public double Solde { get; }
      

        public static int Nb_Comptes { get; }
        

        public Compte()
        {
            nb_comptes++;
            code = nb_comptes;
        }

        public Compte(double solde)
        {
            nb_comptes++;
            code = nb_comptes;
            this.solde = solde;
            
        }

        public virtual void deposer(double somme)               //méthode virtuelle qui peut être redéfinie dans une classe dérivée
        {
            solde += somme;
        }

        public virtual void retirer(double sommme)             ////méthode virtuelle qui peut être redéfinie dans une classe dérivée
        {
            solde -= sommme;
        }

        public override string ToString()
        {
            return "Code: " + code + " Solde: " + solde;
        }
    }
}
