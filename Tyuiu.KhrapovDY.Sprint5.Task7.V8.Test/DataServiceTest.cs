using System.IO;
using Tyuiu.KhrapovDY.Sprint5.Task7.V8.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"�:\DataSprint5\InPutDataFileTask7V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}