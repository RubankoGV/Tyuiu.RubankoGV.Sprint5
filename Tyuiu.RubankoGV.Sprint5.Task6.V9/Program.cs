using Tyuiu.RubankoGV.Sprint5.Task6.V9.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V25.txt");
            Console.WriteLine("Данные находятся в файле:" + path);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество элеметов длина которых 3 символа " + res);

            Console.ReadKey();
        }
    }
}
