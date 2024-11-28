using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RubankoGV.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string str1 = str.Replace(".", ",");
            double x = Convert.ToDouble(str1);
            double res = Math.Round(((Math.Cos(x) + (3 * x)) / (0.25 * x)) + 4 - (2.1 * x), 3);
            return res;
        }
    }
}
