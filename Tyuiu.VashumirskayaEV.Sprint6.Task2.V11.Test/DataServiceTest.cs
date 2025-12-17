using Tyuiu.VashumirskayaEV.Sprint6.Task2.V11.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task2.V11.Test
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
                -14.40,  
                -12.56,  
                -10.07,  
                -7.31,  
                0,       
                3.29,   
                5.57,   
                7.30,  
                8.82,   
                10.28,   
                11.71  
            };

            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01);
            }
        }
    }
}
