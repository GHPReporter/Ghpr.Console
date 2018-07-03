using System;
using Ghpr.Core.Interfaces;

namespace Ghpr.Console
{
    public class EmptyTestDataProvider : ITestDataProvider
    {
        public Guid GetCurrentTestRunGuid()
        {
            return Guid.NewGuid();
        }

        public string GetCurrentTestRunFullName()
        {
            return "";
        }
    }
}