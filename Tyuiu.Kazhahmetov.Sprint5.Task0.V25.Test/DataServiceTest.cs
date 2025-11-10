using Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Lib;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            DataService ds = new DataService();
            bool res = File.Exists(ds.SaveToFileTextData(x));
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
