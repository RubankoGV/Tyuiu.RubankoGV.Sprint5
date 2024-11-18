using Tyuiu.RubankoGV.Sprint5.Task0.V2.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
