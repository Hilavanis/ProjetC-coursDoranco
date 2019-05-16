using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice8BienEntrepriseApplicationConsole;

namespace Exercice8CompteBancaireApplicationConsole
{
    class ComptePayant : Compte, IBienEntreprise
    {
        public ComptePayant(bool EstDeclare) : base() { }                       //Constructeur par défaut
        public ComptePayant(double solde) : base(solde) { }      //Constructeur d'initialisation

        public bool EstDeclare { get; set; }

        public override string ToString()                        //ToString redéfinie
        {
            return "Compte Payant: " + base.ToString() + "EstDeclare : + " + EstDeclare;
        }

        public override void deposer(double somme)               //La méthode "deposer" redéfinie
        {
            base.deposer(somme);
            base.retirer(5);
        }

        public override void retirer(double somme)              //La méthode "retier" reféfinie
        {
            base.retirer(somme);
            base.retirer(5);
        }
    }
}
