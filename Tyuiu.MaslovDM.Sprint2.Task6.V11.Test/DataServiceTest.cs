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

            Assert.AreEqual("11.05.2023", ds.FindDateOfNextDay(2023, 5, 10));
            Assert.AreEqual("01.03.2023", ds.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("01.05.2023", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("01.01.2024", ds.FindDateOfNextDay(2023, 12, 31));
        }
    }
}