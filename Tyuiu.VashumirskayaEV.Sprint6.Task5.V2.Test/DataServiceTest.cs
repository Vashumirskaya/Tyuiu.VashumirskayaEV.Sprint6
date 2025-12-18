using System.Diagnostics;
using Tyuiu.VashumirskayaEV.Sprint6.Task5.V2.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempFilePath = Path.GetTempFileName();

            try
            {
                string[] testData = { "3,14159", "2,5", "1,234" };
                File.WriteAllLines(tempFilePath, testData);

                double[] result = ds.LoadFromDataFile(tempFilePath);

                Assert.AreEqual(3, result.Length);
                Assert.AreEqual(3.142, result[0]);
                Assert.AreEqual(2.5, result[1]);
                Assert.AreEqual(1.234, result[2]);
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }
    }
}
