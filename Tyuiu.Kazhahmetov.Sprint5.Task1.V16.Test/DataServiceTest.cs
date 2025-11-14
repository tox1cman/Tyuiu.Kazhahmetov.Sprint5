using Tyuiu.Kazhahmetov.Sprint5.Task1.V16.Lib;
namespace Tyuiu.Kazhahmetov.Sprint5.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(noway);

            Assert.IsTrue(fl.Exists);
            
        }
    }
}
