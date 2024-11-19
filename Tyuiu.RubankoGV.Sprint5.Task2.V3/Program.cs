using System.Numerics;
using Tyuiu.RubankoGV.Sprint5.Task2.V3.Lib;
namespace Tyuiu.RubankoGV.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3]{{ 5, 9, 1 },
                                        { 1, 3, 9 },
                                        { 1, 2, 2 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
            }
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
