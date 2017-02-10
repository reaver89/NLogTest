using NLogTest.Logging;

namespace NLogTest.Test.LoggingTests.Common
{
    public interface ISampleLoggingClass
    {
        ILogAdapter GetLogger();
    }
}