
using Tyuiu.NovikovAA.Sprint4.Task3.V7.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] { { 9, 6, 9, 3, 7 },
                                          { 3, 3, 3, 8, 2 },
                                          { 2, 1, 3, 5, 2 },
                                          { 6, 2, 3, 2, 5 },
                                          { 4, 5, 6, 9, 5 }
                                                             };

            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mas2[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            int res = ds.Calculate(mas2);
            Console.WriteLine("Количество нечетных элементов: " + res);
            Console.ReadKey();
        }
    }
}
