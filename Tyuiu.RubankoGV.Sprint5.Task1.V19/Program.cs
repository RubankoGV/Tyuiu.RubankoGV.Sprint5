using Tyuiu.RubankoGV.Sprint5.Task1.V19.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
