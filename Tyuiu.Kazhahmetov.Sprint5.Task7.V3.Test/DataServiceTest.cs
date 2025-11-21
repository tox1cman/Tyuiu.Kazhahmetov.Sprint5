namespace Tyuiu.Kazhahmetov.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");
            FileInfo fl = new FileInfo(noway);
            Assert.IsTrue(fl.Exists);
        }
    }
}
