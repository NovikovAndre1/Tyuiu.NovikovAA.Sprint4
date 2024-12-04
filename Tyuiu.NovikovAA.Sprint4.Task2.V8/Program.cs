
using System.Security.Cryptography.X509Certificates;
using Tyuiu.NovikovAA.Sprint4.Task2.V8.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************"); 
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArry[i] = rnd.Next(5, 20);
            }
            Console.WriteLine("Массив: ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArry[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            int res = ds.Calculate(numsArry);
            Console.WriteLine("Сумма элементов больше 4 =  " + res);
            Console.ReadKey();
        }
    }
}
