using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kazhahmetov.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string noway = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fl = new FileInfo(noway);

            if (fl.Exists)
            {
                File.Delete(noway);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }


                if (i != rows - 1)
                {
                    File.AppendAllText(noway, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(noway, str);
                }

                str = "";
            }
            return noway;

        }
    }
}
