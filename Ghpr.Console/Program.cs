using System;
using System.IO;

namespace Ghpr.Cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(nameof(args), "No arguments found!");
            }
            if (args[0] == null)
            {
                Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(args[0], "Path argument not found!");
            }
            var path = args[0];
            if (!File.Exists(path))
            {
                Console.WriteLine($"File '{path}' was not found");
                throw new FileNotFoundException("File was not found!", path);
            }
            if (args.Length == 1)
            {
                ReportHelper.GenerateReport(path);
            }
            else
            {
                ReportHelper.GenerateReport(args);
            }
        }
    }
}
