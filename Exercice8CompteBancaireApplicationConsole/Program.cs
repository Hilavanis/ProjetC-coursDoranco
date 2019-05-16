using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8CompteBancaireApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte();
            CompteEpargne C2 = new CompteEpargne();
            ComptePayant C3 = new ComptePayant(false);
            C1.deposer(10000);
            C2.deposer(2000);
            C3.deposer(3000);
            C1.retirer(2000);
            C2.retirer(500);
            C3.retirer(400);
            C2.CalculerInteret();
            Console.Out.WriteLine(C1);
            Console.Out.WriteLine(C2);
            Console.Out.WriteLine(C3);
            Console.ReadKey();
        }
    }
}
