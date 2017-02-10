using NLogTest.Logging;

namespace NLogTest.Test.LoggingTests
{
    public class SimpleClassWithLoggerProperty
    {
        public ILogAdapter Logger { get; set; }
    }
}
