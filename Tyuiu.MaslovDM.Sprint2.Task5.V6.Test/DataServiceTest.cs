using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Sprint2.Task5.V6.Lib;

namespace Tyuiu.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCardName()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 12;
            string res = ds.GetCardName(m, k);
            Assert.AreEqual("Дама пик", res);
        }
    }
}