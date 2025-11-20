using Tyuiu.Kazhahmetov.Sprint5.Task6.V27.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
            FileInfo fl = new FileInfo(noway);
            Assert.IsTrue(fl.Exists);
        }


        [TestMethod]
        public void TestMethod2()
        {
            string noway = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
            DataService ds = new DataService();
            FileInfo fl = new FileInfo(noway);
            Assert.AreEqual(2, ds.LoadFromDataFile(noway));
        }
    }
}
