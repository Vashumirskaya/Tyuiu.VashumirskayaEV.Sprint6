using Tyuiu.VashumirskayaEV.Sprint6.Task4.V12.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, res.Length);
            Assert.AreEqual(-3.82, res[0]);
            Assert.IsTrue(res[5] != double.NaN && res[5] != double.PositiveInfinity);
        }
    }
}
