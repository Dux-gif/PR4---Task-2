using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4___Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] sum = new int[4, 2];
            int[,] arr = new int[4, 2];
            int[,] arr2 = new int[4, 2];

            Random r = new Random();
            Console.WriteLine($"Первая матрица: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {


                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(10);

                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
                
            }
            
            Console.WriteLine($"\nВторая матрица: ");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {


                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = r.Next(10);

                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();


            }
            Console.WriteLine($"\nСуммарная матрица");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = arr[i, j] + arr2[i, j];
                    
                    Console.Write($"{sum[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
