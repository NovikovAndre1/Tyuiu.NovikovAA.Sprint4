
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NovikovAA.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

           

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
