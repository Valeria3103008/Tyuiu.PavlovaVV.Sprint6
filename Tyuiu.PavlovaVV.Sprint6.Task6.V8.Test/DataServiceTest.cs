using System.IO;
using Tyuiu.PavlovaVV.Sprint6.Task6.V8.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
