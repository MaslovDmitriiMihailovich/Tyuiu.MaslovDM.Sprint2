using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task0.V15.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassCompare()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetMassCompare(3105, 275);
            bool[] expected = { false, false, true, true, false, false };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}