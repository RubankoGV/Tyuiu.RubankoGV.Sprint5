using Tyuiu.RubankoGV.Sprint5.Task1.V19.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task1.V19.Test
{
    public class DataServiceTest
    {

        [Test]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\Геннадий\source\repos\Tyuiu.RubankoGV.Sprint5\Tyuiu.RubankoGV.Sprint5.Task1.V2\bin\Debug";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}