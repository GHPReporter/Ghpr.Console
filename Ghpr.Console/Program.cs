using System;
using System.IO;
using Ghpr.MSTest.Utils;
using Ghpr.NUnit.Utils;

namespace Ghpr.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                System.Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(nameof(args), "No arguments found!");
            }
            if (args[0] == null)
            {
                System.Console.WriteLine("Please add path to file with test results as console argument");
                throw new ArgumentNullException(args[0], "Path argument not found!");
            }
            var path = args[0];
            if (!File.Exists(path))
            {
                System.Console.WriteLine($"File '{path} was not found'");
                throw new FileNotFoundException("File was not found!", path);
            }
            var ext = Path.GetExtension(path).ToLower();
            switch (ext)
            {
                case ".xml":
                    GhprNUnitRunHelper.CreateReportFromFile(path);
                    break;
                case ".trx":
                    GhprMSTestRunHelper.CreateReportFromFile(path);
                    break;
                default:
                    throw new Exception($"Unsupported file extension: '{ext}'. " +
                                        "Only '.xml' and '.trx' extensions supported.");
            }
        }
    }
}
