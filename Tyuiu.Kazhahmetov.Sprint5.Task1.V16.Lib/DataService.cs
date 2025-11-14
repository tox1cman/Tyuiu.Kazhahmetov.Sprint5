using Microsoft.Win32;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kazhahmetov.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            FileInfo fl = new FileInfo(noway);

            if (fl.Exists)
            {
                File.Delete(noway);
            }

            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) - (4.0 * x * Math.Cos(x)) + (2.0 * x / 3.0);
                y = Math.Round(y, 2);
                string stry = y.ToString("0.00");

                if (x != stopValue)
                {
                    File.AppendAllText(noway, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(noway, stry);
                }
            }
            return noway;
        }
    }
}
