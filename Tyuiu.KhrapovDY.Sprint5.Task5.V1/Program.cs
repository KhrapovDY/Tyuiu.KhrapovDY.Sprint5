using Tyuiu.KhrapovDY.Sprint5.Task5.V1.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                    *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #1                                                                        *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно *");
            Console.WriteLine("* вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё     *");
            Console.WriteLine("* файл) в котором есть набор значений. Найти сумму всех чисел с признаками деления  *");
            Console.WriteLine("* на 2. Полученный результат вывести на консоль. У вещественных значений округлить  *");
            Console.WriteLine("* до трёх знаков после запятой.                                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\Users\User\Desktop\DataService5\InPutDataFileTask5V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма элементов файла = " + res);
            Console.ReadKey();
        }
    }
}
