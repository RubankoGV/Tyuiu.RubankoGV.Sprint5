using Tyuiu.RubankoGV.Sprint5.Task4.V2.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task4.V2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.RubankoGV.Sprint5";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
