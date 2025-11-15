using Tyuiu.Kazhahmetov.Sprint5.Task2.V5.Lib;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fl = new FileInfo(noway);
            bool res = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
