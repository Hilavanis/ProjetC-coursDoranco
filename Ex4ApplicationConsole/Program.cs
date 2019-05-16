using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4ApplicationConsole
{
    class Program
    {


        static public double addition(double val1, double val2)
        {
            return val1 + val2;
        }
        static public double soustraction(double val1, double val2)
        {
            return val1 - val2;
        }
        static public double multiplication(double val1, double val2)
        {
            return val1 * val2;
        }
        static public double division(double val1, double val2)
        {
            if (val2 != 0)
            {
                return val1 / val2;
            }
            else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            //Je récupère l'expression tapée par l'utilisateur 
            string expression = Console.ReadLine();

            //Je crée un tableau de caractères représentant les opérations     
            char[] operation = { '+', '-', '*', '/' };

            //"Replace" suprime les espaces 
            //"Split" découpe la chaine de caractères avec les caractères 
            //présents dans le tableau operation
            string[] valeur = expression.Replace(" ", "").Split(operation); 
            
            //Converti le premier élément du tableau valeur
            int numero1 = Convert.ToInt32(valeur[0]);
            //Converti le second élément du tableau valeur
            int numero2 = Convert.ToInt32(valeur[1]);

            Console.WriteLine(expression.IndexOf('*'));
            //Recherche la présence de * dans expression 
            //Si expression.IndexOf('*') retourne -1 cela veut dire qu'il n'a pas trouvé *
            if (expression.IndexOf('*') != -1)
            {
                Console.WriteLine("Le résultat de l'opération est" + multiplication(numero1, numero2));

            }
            //Recherche la présence de + dans expression 
            //Si expression.IndexOf('+') retourne -1 cela veut dire qu'il n'a pas trouvé +
            else if (expression.IndexOf('+') != -1)
            {
                Console.WriteLine("Le résultat de l'opération est" + addition(numero1, numero2));

            }
            //Recherche la présence de - dans expression 
            //Si expression.IndexOf('-') retourne -1 cela veut dire qu'il n'a pas trouvé -
            else if (expression.IndexOf('-') != -1)
            {
                Console.WriteLine("Le résultat de l'opération est" + soustraction(numero1, numero2));

            }
            //Recherche la présence de / dans expression 
            //Si expression.IndexOf('/') retourne -1 cela veut dire qu'il n'a pas trouvé /
            else if (expression.IndexOf('/') != -1)
            {
                Console.WriteLine("Le résultat de l'opération est" + division(numero1, numero2));

            }

            /*
            Console.WriteLine("entrez un nombre");
            valeur1 = double.Parse(Console.ReadLine());
            Console.WriteLine("entrez un second nombre");
            valeur2 = double.Parse(Console.ReadLine());
           

            do
            {
               
                Console.WriteLine("Choisissez un type d'opérations");
                Console.WriteLine("+ pour addition");
                Console.WriteLine("- pour soustraction");
                Console.WriteLine("* pour multiplication");
                Console.WriteLine("/ pour division");

                //choix = int.Parse(Console.ReadLine());
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "+":
                        Console.WriteLine("Le résultat de l'opération est" + addition(valeur1, valeur2));
                        break;
                    case "-":
                        Console.WriteLine("Le résultat de l'opération est" + soustraction(valeur1, valeur2));
                        break;
                    case "*":
                        Console.WriteLine("Le résultat de l'opération est" + multiplication(valeur1, valeur2));
                        break;
                    case "/":
                        Console.WriteLine("Le résultat de l'opération est" + division(valeur1, valeur2));
                        break;
                    default :
                        Console.WriteLine("Je n'ai pas compris ce que tu as entré");
                        break;
                }
                /*
                if (choix == 1)
                {
                    Console.WriteLine("Le résultat de l'opération est" + addition(valeur1, valeur2));

                }
                else if (choix == 2)
                {
                    Console.WriteLine("Le résultat de l'opération est" + soustraction(valeur1, valeur2));

                }
                else if (choix == 3)
                {
                    Console.WriteLine("Le résultat de l'opération est" + multiplication(valeur1, valeur2));

                }
                else if (choix == 4)
                {
                    Console.WriteLine("Le résultat de l'opération est" + division(valeur1, valeur2));

                }
            } while (choix != 4 || choix != 3 || choix != 2 || choix != 1);*/


            Console.ReadKey();

        }

    }
}
