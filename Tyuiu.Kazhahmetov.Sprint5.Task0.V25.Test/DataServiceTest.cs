using System.IO;
using Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(noway);
            bool res = fl.Exists;
            Assert.AreEqual(true, res);
        }
    }
}
