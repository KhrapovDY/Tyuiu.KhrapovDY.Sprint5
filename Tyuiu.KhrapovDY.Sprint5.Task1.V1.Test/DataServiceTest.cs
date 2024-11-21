namespace Tyuiu.KhrapovDY.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KhrapovDY.Sprint5\Tyuiu.KhrapovDY.Sprint5.Task0.V11\bin\Debug";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}