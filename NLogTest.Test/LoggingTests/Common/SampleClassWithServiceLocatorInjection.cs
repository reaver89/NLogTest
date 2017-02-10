using Autofac;
using NLogTest.Logging;

namespace NLogTest.Test.LoggingTests.Common
{
    public class SampleClassWithServiceLocatorInjection:ISampleLoggingClass
    {
        public ILogAdapter Logger;

        public SampleClassWithServiceLocatorInjection(ILifetimeScope locator)
        {
            Logger = locator.Resolve<ILogAdapter>();
        }

        public ILogAdapter GetLogger()
        {
            return Logger;
        }
    }
}
