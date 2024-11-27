﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhrapovDY.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string[] str;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", " ");
                    str = line.Split(' ');
                    foreach (string word in str)
                    {
                        int lenght = word.Length;
                        if (lenght == 3)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}