using Tyuiu.RubankoGV.Sprint5.Task2.V3.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task2.V3.Test
{
    public class DataServiceTest
    {

        [Test]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\Геннадий\source\repos\Tyuiu.RubankoGV.Sprint5\Tyuiu.RubankoGV.Sprint5.Task2.V3\bin\Debug";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}