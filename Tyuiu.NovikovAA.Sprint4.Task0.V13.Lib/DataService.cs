﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovAA.Sprint4.Task0.V13.Lib
{
    public class DataService : ISprint4Task0V13
    {
        public int GetSumEvenArrEl(int[] array)
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