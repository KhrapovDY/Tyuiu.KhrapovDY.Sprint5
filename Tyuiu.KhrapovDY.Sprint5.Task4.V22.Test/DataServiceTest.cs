using System.IO;

namespace Tyuiu.KhrapovDY.Sprint5.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask4V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}