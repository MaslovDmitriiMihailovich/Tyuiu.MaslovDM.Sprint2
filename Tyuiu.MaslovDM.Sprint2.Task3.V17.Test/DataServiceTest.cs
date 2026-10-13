using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task3.V17.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double res = ds.Calculate(x);
            double wait = 6565.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double res = ds.Calculate(x);
            double wait = -0.286;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double res = ds.Calculate(x);
            double wait = 16.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -22.0;
            double res = ds.Calculate(x);
            double wait = -241.955;
            Assert.AreEqual(wait, res);
        }
    }
}