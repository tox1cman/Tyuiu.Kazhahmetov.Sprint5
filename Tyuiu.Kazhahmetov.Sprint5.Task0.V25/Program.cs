using Tyuiu.Kazhahmetov.Sprint5.Task0.V25.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3;
Console.WriteLine("X = " + x);  

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);
Console.WriteLine(res);
Console.ReadKey();