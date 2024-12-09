
using Tyuiu.NovikovAA.Sprint4.Task7.V18.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "145258749635789";

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество чего то там: " + res);
            Console.ReadKey();
        }
    }
}
