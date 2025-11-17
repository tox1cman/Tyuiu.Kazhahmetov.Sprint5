using Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = @"С:\DataSprint5\InPutDataFileTask4V0.txt";
            FileInfo fl = new FileInfo(noway);

            Assert.IsTrue(fl.Exists);
        }
    }
}
