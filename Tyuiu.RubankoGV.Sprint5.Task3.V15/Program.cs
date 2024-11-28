
using Tyuiu.RubankoGV.Sprint5.Task3.V15.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int x = 5;
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
