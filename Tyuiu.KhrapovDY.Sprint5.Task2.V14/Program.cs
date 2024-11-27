using Tyuiu.KhrapovDY.Sprint5.Task2.V14.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3] { { -3, -6, -3 }, { 6, 8, 3 }, { -6, -5, 5 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл                *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #14                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с     *");
            Console.WriteLine("* клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0.     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.              *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Массив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: =" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
