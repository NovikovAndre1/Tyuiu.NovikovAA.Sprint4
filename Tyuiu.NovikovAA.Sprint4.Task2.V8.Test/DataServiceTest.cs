
using Tyuiu.NovikovAA.Sprint4.Task2.V8.Lib;


namespace Tyuiu.NovikovAA.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int[] numsArray = { 2, 2, 3, 4, 5, 3, 6, 4, 6, 7, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}