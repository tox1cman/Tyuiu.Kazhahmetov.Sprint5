using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string tempFile = Path.GetTempFileName();
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";

            string file = Path.Combine(tempPath, fileName);
           

            double res = ((3 * Math.Pow(x, 4)) + 1) / Math.Pow(x, 3);
            File.WriteAllText(file, Convert.ToString(res));
            return file;
        }
    }
}
