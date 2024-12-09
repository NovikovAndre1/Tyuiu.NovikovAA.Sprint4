
using System;
using Tyuiu.NovikovAA.Sprint4.Task5.V11.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количство столбцов");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, colums];
            Console.WriteLine("********************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    mtrx[i, j] = rnd.Next(-7, 2);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        mtrx[i, j] = 1;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");


            int[,] res = ds.Calculate(mtrx);
            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(res[i, j] + " "); // Убрали ,4
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
