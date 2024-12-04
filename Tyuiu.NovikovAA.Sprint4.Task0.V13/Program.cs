
using Tyuiu.NovikovAA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
           


            for (int i = 0; i <= numsArray.Length - 1; i++) 
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            int sum = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных чисел: " + sum);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
