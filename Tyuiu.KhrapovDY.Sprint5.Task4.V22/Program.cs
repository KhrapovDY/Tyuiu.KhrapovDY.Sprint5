using Tyuiu.KhrapovDY.Sprint5.Task4.V22.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                           *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #22                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно *");
            Console.WriteLine("* вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё     *");
            Console.WriteLine("* файл) в котором есть вещественное значение.Прочитать значение из файла и          *");
            Console.WriteLine("* подставить вместо Х в формуле y = x^3 * sin x - 4x. Вычислить значение по формуле *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный *");
            Console.WriteLine("* результат на консоль.                                                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"С:\DataSprint5\InPutDataFileTask4V22.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}