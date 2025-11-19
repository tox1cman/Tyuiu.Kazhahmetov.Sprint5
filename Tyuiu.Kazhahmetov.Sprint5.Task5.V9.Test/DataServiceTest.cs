using Tyuiu.Kazhahmetov.Sprint5.Task5.V9.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string noway = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
            FileInfo fl = new FileInfo(noway);
            double res = ds.LoadFromDataFile(noway);
            Assert.AreEqual(25, res);
        }
    }
}
