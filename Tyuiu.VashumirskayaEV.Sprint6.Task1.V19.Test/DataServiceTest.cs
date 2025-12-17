using Tyuiu.VashumirskayaEV.Sprint6.Task1.V19.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] actual = ds.GetMassFunction(startValue, stopValue);

            double[] expected = new double[]
            {
                15.19, 11.67, 9.00, 0.00, 4.08, 1.50, -2.28, -6.52, -10.19, -12.76, -14.68
            };

            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
