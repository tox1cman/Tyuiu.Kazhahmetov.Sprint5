using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        { 
            string x = File.ReadAllText(path);
            double y = Convert.ToDouble(x);
            double res = Math.Pow(y, -3) + 2 + Math.Cos(y);
            return res;
        }
    }
}
