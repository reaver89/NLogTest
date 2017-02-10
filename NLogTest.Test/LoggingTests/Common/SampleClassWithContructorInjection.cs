using NLogTest.Logging;

namespace NLogTest.Test.LoggingTests.Common
{
    public class SampleClassWithContructorInjection
    {
        public ILogAdapter Logger;
        public SampleClassWithContructorInjection(ILogAdapter logger)
        {
            Logger = logger;
        }
    }
}