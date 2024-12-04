
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
            
            int[] numsArray = { 5, 5, 4, 7, 3, 4, 5, 2, 2, 5, 2 };

            int res = ds.Calculate(numsArray);
            int wait = 27;

            Assert.AreEqual(wait, res);
        }
    }
}