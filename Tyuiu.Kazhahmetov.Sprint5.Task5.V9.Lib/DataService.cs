using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = -1.0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line.Replace(".", ",")) > res)
                    {
                        res = Convert.ToDouble(line.Replace(".", ","));
                    }
                }
            }
            return res;
        }
    }
}
