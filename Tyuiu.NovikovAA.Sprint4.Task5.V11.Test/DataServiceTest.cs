
using Tyuiu.NovikovAA.Sprint4.Task5.V11.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMatrix()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -1, -3, -1, -4, 2 },
                                          { -1, -1, -2, -7, -1 },
                                          { 2, -6, 1, -6, -6 },
                                          { -6, 0, -3, -3, -4 },
                                          { 1, -6, -6, 0, -7 }
                                                             };
            
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[,] {
            { -1, -3, -1, -4, 1 },
            { -1, -1, -2, -7, -1 },
            { 1, -6, 1, -6, -6 },
            { -6, 0, -3, -3, -4 },
            { 1, -6, -6, 0, -7 }
        };

            Assert.AreEqual(wait, res);
        }
    }
}