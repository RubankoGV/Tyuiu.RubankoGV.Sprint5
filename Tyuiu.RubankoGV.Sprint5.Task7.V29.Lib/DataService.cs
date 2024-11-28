using System.Text.RegularExpressions;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RubankoGV.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V29.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool FileExsits = fileInfo.Exists;
            if (FileExsits)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    strLine = Regex.Replace(line, @"b\d\b", String.Empty);
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
