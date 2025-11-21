using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kazhahmetov.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");

            FileInfo fl = new FileInfo(noway);

            if (fl.Exists)
            {
                File.Delete(noway);
            }

            string text = File.ReadAllText(path);

            string res = Regex.Replace(text, @"[а-яА-ЯёЁ]", "");
            File.WriteAllText(noway, res);
            return noway;
        }
    }
}
