using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            int res = -1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToInt32(line) > res)
                    {
                        res = Convert.ToInt32(line);
                    }
                }
            }
            return res;
        }
    }
}
