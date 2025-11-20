using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kazhahmetov.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string line = File.ReadAllText(path);

            foreach (string numb in line.Split(" "))
            {
                int x = Convert.ToInt32(numb);
                if ((x > 99) && (x < 1000))
                {
                    count++;
                } 
            }
            return count;
        }
    }
}
