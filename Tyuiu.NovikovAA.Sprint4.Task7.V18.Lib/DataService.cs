﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovAA.Sprint4.Task7.V18.Lib
{
    public class DataService : ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(index++, 1));
                }
            }

            int product = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        product *= mtrx[i, j];
                    }
                }
            }
            return product;
        }
    }
}
