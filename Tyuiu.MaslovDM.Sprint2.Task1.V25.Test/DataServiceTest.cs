using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint2.Task1.V25.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}