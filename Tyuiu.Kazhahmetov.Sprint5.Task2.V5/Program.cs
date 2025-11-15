using Tyuiu.Kazhahmetov.Sprint5.Task2.V5.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = new int[3, 3] { { 9, 6, 6, },
                                { 8, 7, 2, },
                                { 1, 7, 8, } } ;

int rows = matrix.GetUpperBound(0) + 1;
int cols = matrix.Length / rows;

Console.WriteLine("Massive: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }

    Console.WriteLine();
}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine(res);
Console.ReadKey();
