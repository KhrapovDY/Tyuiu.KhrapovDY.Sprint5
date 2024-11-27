using Tyuiu.KhrapovDY.Sprint5.Task6.V9.Lib;

namespace Tyuiu.KhrapovDY.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = @"Ñ:\DataSprint5\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            int wait = 2;
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}