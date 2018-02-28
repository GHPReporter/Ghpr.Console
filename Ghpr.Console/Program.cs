using System;
using System.IO;

namespace Ghpr.Console
{
    public class Program
    {
        public static void Main(string[] paths)
        {
            if (paths == null)
            {
                System.Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(nameof(paths), "No arguments found!");
            }
            if (paths[0] == null)
            {
                System.Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(paths[0], "Path argument not found!");
            }
            var path = paths[0];
            if (!File.Exists(path))
            {
                System.Console.WriteLine($"File '{path}' was not found");
                throw new FileNotFoundException("File was not found!", path);
            }
            if (paths.Length == 1)
            {
                ReportHelper.GenerateReport(path);
            }
            else
            {
                ReportHelper.GenerateReport(paths);
            }
        }
    }
}
