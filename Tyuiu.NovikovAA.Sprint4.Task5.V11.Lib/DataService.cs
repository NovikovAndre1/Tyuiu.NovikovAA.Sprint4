
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NovikovAA.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] resultMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        resultMatrix[i, j] = 1;
                    }
                    else
                    {
                        resultMatrix[i, j] = matrix[i, j]; // Копируем значение, если оно не > 0
                    }
                }
            }
            return resultMatrix;
        }
    }
}
