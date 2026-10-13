using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task4.V23.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 4.0;

            double res = ds.Calculate(x, y);
            double wait = 39.667;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 16.0;

            double res = ds.Calculate(x, y);
            double wait = 1.008;
            Assert.AreEqual(wait, res);
        }
    }
}