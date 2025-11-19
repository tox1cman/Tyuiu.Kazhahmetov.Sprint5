using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = -1.0;
            string line = File.ReadAllText(path);
            {
                foreach (string numb in line.Split(" "))
                {
                    double x = Convert.ToDouble(numb);
                    if (x > res)
                    {
                        res = x;
                    }
                }
                return res;
            }
        }
    }
}