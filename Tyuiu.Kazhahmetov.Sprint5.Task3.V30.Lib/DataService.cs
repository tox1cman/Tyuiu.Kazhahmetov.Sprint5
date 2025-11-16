using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Net;
namespace Tyuiu.Kazhahmetov.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(noway);
            if (fl.Exists)
            {
                File.Delete(noway);
            }

            double y;
            y = (x * x * x - 1.0) / (4.0 * x * x);
            y = Math.Round(y, 2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(noway, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return noway;
        }
    }
}
