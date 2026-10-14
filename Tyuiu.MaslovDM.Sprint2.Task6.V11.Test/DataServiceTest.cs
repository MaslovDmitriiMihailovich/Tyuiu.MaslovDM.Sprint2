using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task6.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("11.5.2023", ds.FindDateOfNextDay(2023, 5, 10));
            Assert.AreEqual("1.3.2023", ds.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("1.5.2023", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("1.1.2024", ds.FindDateOfNextDay(2023, 12, 31));
        }
    }
}