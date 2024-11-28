
using Tyuiu.RubankoGV.Sprint5.Task7.V29.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("* Исходные данные: C:\\DataSprint5\\InPutDataFileTask7V29.txt             *");
            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";
            Console.WriteLine("* Результат:                                                              *");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
        }
    }
}
