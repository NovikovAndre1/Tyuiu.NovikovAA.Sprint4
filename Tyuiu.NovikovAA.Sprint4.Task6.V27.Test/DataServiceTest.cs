
using Tyuiu.NovikovAA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.NovikovAA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var week = new string[] { "�������", "�������������", "����", "�����������", "������������", "�������������", "��������������" };
            int res = ds.Calculate(week);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}