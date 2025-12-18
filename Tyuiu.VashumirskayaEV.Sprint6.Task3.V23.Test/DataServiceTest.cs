using Tyuiu.VashumirskayaEV.Sprint6.Task3.V23.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 0, -19, 25, 34, 0 },
                { -19, -16, 1, -5, 34 },
                { 1, 13, -5, -17, -5 },
                { 3, -9, -15, -1, 0 },
                { 1, 20, 15, -5, 31 }
            };

            int[,] expected =
            {
                { 0, -19, 25, 34, 0 },
                { -19, -16, 1, -5, 34 },
                { 1, -9, -5, -17, -5 },
                { 3, 13, -15, -1, 0 },
                { 1, 20, 15, -5, 31 }
            };

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Assert.AreEqual(expected[i, j], result[i, j]);
        }
    }
}
