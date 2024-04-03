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
            
            int sum = 0;
            int[,] arr = new int[2, 3];
            int[,] arr2 = new int[2, 3];

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
            foreach (int i in arr)
            {
                sum += i;
            }
            foreach (int j in arr2)
            {
                sum += j;
            }
            Console.Write($"\nСумма двух матриц: {sum}");
            Console.ReadLine();
        }
    }
}
