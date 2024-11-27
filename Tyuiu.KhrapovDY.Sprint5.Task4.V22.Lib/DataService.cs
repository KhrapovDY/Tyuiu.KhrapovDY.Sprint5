using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhrapovDY.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double x = double.Parse(strX);
            double res = Math.Round(Math.Pow(x, 3) * Math.Sin(x) - 4 * x, 3);
            return res;
        }
    }
}
