
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NovikovAA.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i <= array.Length-1; i++) 
            {
                if (array[i] > 4)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
