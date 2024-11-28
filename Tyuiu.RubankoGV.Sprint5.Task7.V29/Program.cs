
using Tyuiu.RubankoGV.Sprint5.Task7.V29.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V29.txt");
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле:");
            Console.WriteLine(ds.LoadDataAndSave(path));
            Console.ReadKey();
        }
    }
}
