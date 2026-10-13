using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task2.V19.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}