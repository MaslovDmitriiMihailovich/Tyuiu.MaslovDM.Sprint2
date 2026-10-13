using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task0.V15.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperations()
        {
            DataService ds = new DataService();

            bool[] res = ds.GetCompareOperations(3105, 275);
            bool[] expected = { false, true, false, true, false, true };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}