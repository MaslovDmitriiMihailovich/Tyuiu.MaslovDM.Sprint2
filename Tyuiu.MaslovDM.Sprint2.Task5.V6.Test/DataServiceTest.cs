using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task5.V6.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 12;
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual("Дама пик", res);
        }
    }
}