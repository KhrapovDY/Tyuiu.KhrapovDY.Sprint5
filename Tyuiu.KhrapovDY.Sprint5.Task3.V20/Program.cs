using Tyuiu.KhrapovDY.Sprint5.Task3.V20.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3;

            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                               *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #20                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный   *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после     *");
            Console.WriteLine("* запятой.                                                                          *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл =" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
