using System.IO;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhrapovDY.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "output.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string str = "";
                string a = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (Char.IsUpper(line[i]) && a.Contains(line[i]))
                        {
                            str += Char.ToLower(line[i]);
                        }
                        else
                        {
                            str += line[i];
                        }
                    }
                    File.WriteAllText(pathSaveFile, str);
                }
                return pathSaveFile;
            }
        }

    }
}