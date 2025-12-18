using Tyuiu.VashumirskayaEV.Sprint6.Task6.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\huawei\source\repos\Tyuiu.VashumirskayaEV.Sprint6\файлы\InPutDataFileTask6V26.txt";
            bool exists = File.Exists(path);
            Assert.IsTrue(exists);
        }
    }
}
