using System.Diagnostics.CodeAnalysis;
using Tyuiu.Kazhahmetov.Sprint5.Task3.V30.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(noway);

            Assert.IsTrue(fl.Exists);

        }
    }
}
