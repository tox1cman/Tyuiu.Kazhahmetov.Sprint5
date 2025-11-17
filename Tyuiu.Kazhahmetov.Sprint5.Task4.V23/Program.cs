using Tyuiu.Kazhahmetov.Sprint5.Task4.V23.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string noway = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V23.txt";
Console.WriteLine(noway);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(noway);
Console.WriteLine(res);
Console.ReadKey();

