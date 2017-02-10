using NLogTest.Logging;

namespace NLogTest.Test.LoggingTests
{
    public class SimpleClassWithContructorInjection
    {
        public ILogAdapter Logger;
        public SimpleClassWithContructorInjection(ILogAdapter logger)
        {
            Logger = logger;
        }
    }
}