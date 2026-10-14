using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task7.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 3));
        }
    }
}