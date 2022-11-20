using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace JuggedPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[3];
            Names[0] = "Faruk";
            Names[1] = "Harun";
            Names[2] = "Mamun";

            string[][] FavouriteFood = new string[3][];
            FavouriteFood[0] = new string[3];
            FavouriteFood[1] = new string[2];
            FavouriteFood[2] = new string[4];

            FavouriteFood[0][0] = "Rice";
            FavouriteFood[0][1] = "Kacchi";
            FavouriteFood[0][2] = "Smashed potato";

            FavouriteFood[1][0] = "Fried Rice";
            FavouriteFood[1][1] = "Smashed potato";


            FavouriteFood[2][0] = "Fish";
            FavouriteFood[2][1] = "Smashed potato";
            FavouriteFood[2][2] = "Dal";
            FavouriteFood[2][3] = "Smashed potato";


            for (int i = 0; i <FavouriteFood.Length; i++)
            {
                Console.WriteLine($"{Names}  and {Names[i]} \n-------------------------");
                for (int j = 0; j < FavouriteFood[i].Length; j++)
                {
                    Console.WriteLine("{0}  ",FavouriteFood[i][j]);
                }
                Console.WriteLine($"\n\n");

            }
            Console.ReadKey();
        }
    }
}
