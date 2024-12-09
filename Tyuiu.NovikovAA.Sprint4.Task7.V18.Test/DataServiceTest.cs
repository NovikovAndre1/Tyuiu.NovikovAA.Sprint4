
using Tyuiu.NovikovAA.Sprint4.Task7.V18.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "145258749635789";
            int res = ds.Calculate(n, m, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}