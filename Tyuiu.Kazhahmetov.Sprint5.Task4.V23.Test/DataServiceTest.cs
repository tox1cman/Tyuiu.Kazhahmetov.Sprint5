using Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string noway = @"C:\DataSprint5\InPutDataFileTask4V23.txt";
            FileInfo fl = new FileInfo(noway);
            double res = ds.LoadFromDataFile(noway);
            Assert.AreEqual(res, res);
        }
    }
}
