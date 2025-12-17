using Tyuiu.VashumirskayaEV.Sprint6.Task0.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(4);
            double wait = -6.000;
            Assert.AreEqual(wait, res);
        }
    }
}
