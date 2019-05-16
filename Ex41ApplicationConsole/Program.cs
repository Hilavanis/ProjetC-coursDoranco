using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex41ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] simple; //Déclaration 

            //simple[0] = 5;//impossible 

            /****Premiere écriture*****/
            /*simple = new int[5]; //instancier == créer 

            simple[0] = 5;
            simple[1] = 10;
            simple[2] =2;
            simple[3] = 3;
            simple[4] = 4;*/

            /****Deuxième écriture*****/
            /* simple = new int[5] { 5, 10, 2, 3};//nok
             simple = new int[5] { 5, 10, 2, 3, 4 };//ok*/

            /****Troisème écriture*****/
                //simple = new int[] { 5, 10, 2, 3, 5, 5, 2};
                        // simple[7] = 10; //FAUX IMPOSSIBLE

            /****Quatrieme écriture*****/
            int[] simple2 = { 5, 10, 2, 3, 5, 5, 2 };

            /**Multidimensionnel**/
            int[,] multi = { {5,10}, { 4, 5 }, { 3, 1 }, { 6, 7 }, { 3, 4 }};

            /**Tableau en escalier**/
            int[][] escalier = { new int[] { 5, 4 }, new int[] { 6, 1 }, new int[] { 7, 3 }, new int[] { 8, 1 }, new int[] { 9, 0 } };
            int[][][] escalier1 = { new int[][] { new int[] { 5, 4,3 } }, new int[][] { new int[] { 5, 4, 3 } }, new int[][] { new int[] { 5, 4, 3 } }, new int[][] { new int[] { 5, 4, 3 } }, new int[][] { new int[] { 5, 4, 3 } } };


            Console.WriteLine($"entrez l'apération que vous souhaitez effectuer {escalier[0][1]}");

 string operation = Console.ReadLine();

 Console.WriteLine($"{operation}");
 Console.ReadKey();
}
}
}
