﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovAA.Sprint4.Task1.V5.Lib
{
    public class DataService : ISprint4Task1V5
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}