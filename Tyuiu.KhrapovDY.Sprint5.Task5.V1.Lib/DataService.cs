using System.Diagnostics.CodeAnalysis;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhrapovDY.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = line.Split(',');
                    foreach (string x in str)
                    {
                        if (Convert.ToDouble(x) % 2 == 0)
                        {
                            string y = line.Replace(".", ",");
                            res += Convert.ToDouble(x);
                        }
                    }
                }
                return Math.Round(res, 3);
            }
        }
    }
}