using Tyuiu.KhrapovDY.Sprint5.Task1.V1.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                           *");
            Console.WriteLine("* Задание #0                                                                        *");
            Console.WriteLine("* Вариант #11                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дана функция, F(x) = 5x + 2,5 / sin(x) + 2 + 2x + 2 (произвести табулирование)    *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль *");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Результат сохранить в текстовый файл      *");
            Console.WriteLine("* OutPutFileTaskl.txt и вывести на консоль в таблицу. Значения округлить до двух    *");
            Console.WriteLine("* знаков после запятой.                                                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
