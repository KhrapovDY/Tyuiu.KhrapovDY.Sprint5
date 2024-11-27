using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhrapovDY.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double res = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);

            res = Math.Round(res, 3);

            File.WriteAllText(path, Convert.ToString(res));
            return path;

        }
    }
}
