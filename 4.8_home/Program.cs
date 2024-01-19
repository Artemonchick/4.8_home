using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1

            Console.Write("Введите количество строк в матрице: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("\nВведите количество столбцов в матрице: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];

            Random r = new Random();
            int sum = 0;

            Console.WriteLine("\nПолученная матрица A: ");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(10);
                    Console.Write($"{A[i, j]} ");
                    sum += A[i, j];
                }
                Console.WriteLine();
            }

            Console.Write($"\nКоличество элементов в матрице A: {A.Length}");
            Console.Write($"\nСумма элементов в матрице A = {sum}");

            #endregion

            #region Задание 2

            int[,] B = new int[m, n];

            Console.WriteLine("\n\nПолученная матрица B: ");

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = r.Next(10);
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }

            int[,] C = new int[m, n];

            Console.WriteLine("\n\nСумма матриц A и B: ");

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write($"{C[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            #endregion

        }
    }
}
