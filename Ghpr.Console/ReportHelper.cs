using System;
using System.Collections.Generic;
using System.IO;
using Ghpr.Core.Common;
using Ghpr.Core.Factories;
using Ghpr.MSTest.Utils;
using Ghpr.NUnit.Utils;

namespace Ghpr.Console
{
    public class ReportHelper
    {
        public static void GenerateReport(string path)
        {
            var ext = Path.GetExtension(path)?.ToLower();
            switch (ext)
            {
                case ".xml":
                    GhprNUnitRunHelper.CreateReportFromFile(path);
                    break;
                case ".trx":
                    GhprMSTestRunHelper.CreateReportFromFile(path, new EmptyTestDataProvider());
                    break;
                default:
                    throw new Exception($"Unsupported file extension: '{ext}'. " +
                                        "Only '.xml' and '.trx' extensions supported.");
            }
        }

        public static void GenerateReport(string[] paths)
        {
            var reporter = ReporterFactory.Build(new EmptyTestDataProvider());
            var tests = new List<KeyValuePair<TestRunDto, TestOutputDto>>();
            foreach (var path in paths)
            {
                var ext = Path.GetExtension(path)?.ToLower();
                switch (ext)
                {
                    case ".xml":
                        tests.AddRange(GhprNUnitRunHelper.GetTestRunsListFromFile(path, reporter.Logger));
                        break;
                    case ".trx":
                        tests.AddRange(GhprMSTestRunHelper.GetTestRunsListFromFile(path));
                        break;
                    default:
                        System.Console.WriteLine($"Unsupported file extension: '{ext}' for file '{path}'. " +
                                            "Only '.xml' and '.trx' extensions supported.");
                        break;
                }
            }
            reporter.GenerateFullReport(tests);
        }
    }
}