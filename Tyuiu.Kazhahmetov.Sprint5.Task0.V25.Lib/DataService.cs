using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = ((3 * Math.Pow(x, 4)) + 1) / Math.Pow(x, 3);
            File.WriteAllText(noway, Convert.ToString(res));
            return noway;
        }
    }
}
