
using Tyuiu.NovikovAA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray =  26;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}