using System.Text.RegularExpressions;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RubankoGV.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29

    {
        public string LoadDataAndSave(string path)
        {
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });
            File.Delete(s);
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                string str = "0123456789";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] l = line.Split(" ");
                    for (int i = 0; i < l.Length; i++)
                    {
                        if (l[i].Length == 1 & str.Contains(l[i]))
                        {
                            l[i] = "";
                        }
                    }
                    string line1 = string.Join(" ", l);
                    line1 = line1.Replace("  ", " ");
                    File.AppendAllText(s, line1);
                }
            }
            return s;
        }
    }
}

