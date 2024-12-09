
using Tyuiu.NovikovAA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            var week = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= week.Length - 1; i++)
            {
                Console.WriteLine(week[i]);
            }

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Количество элементов которые меньше 7: ");

            int nums = ds.Calculate(week);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
