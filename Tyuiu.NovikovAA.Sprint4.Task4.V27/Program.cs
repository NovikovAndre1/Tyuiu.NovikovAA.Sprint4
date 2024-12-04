
using Tyuiu.NovikovAA.Sprint4.Task4.V27.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, colums];

            Console.WriteLine("********************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива: ");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Сумма нечетных элементов: " + res);
            Console.ReadKey();
        }
    }
}
