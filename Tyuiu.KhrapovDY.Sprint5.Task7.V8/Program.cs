using Tyuiu.KhrapovDY.Sprint5.Task7.V8.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                            *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #8                                                                        *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно *");
            Console.WriteLine("* вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё     *");
            Console.WriteLine("* файл) в котором есть набор символьных данных. Заменить все заглавные русские      *");
            Console.WriteLine("* буквы на строчные.Полученный результат сохранить в файл OutPutDataFileTask7V8.txt.*");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"С:\DataSprint5\InPutDataFileTask7V8.txt";
            string pathSaveFile = @"С:\DataSprint5\InPutDataFileTask7V8.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();

        }
    }
}