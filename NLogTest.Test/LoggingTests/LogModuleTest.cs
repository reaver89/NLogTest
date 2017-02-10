using Autofac;
using NLogTest.Logging.Modules;
using NLogTest.Test.LoggingTests.Common;
using NUnit.Framework;


namespace NLogTest.Test.LoggingTests
{
    [TestFixture]
    public class LogModuleTest
    {
        private IContainer _container;

        [OneTimeSetUp]
        public void Setup()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<LogModule>();
            builder.RegisterType<SampleClassWithServiceLocatorInjection>().As<ISampleLoggingClass>();

            _container = builder.Build();
        }

        [Test]
        public void LogModule_Using_Service_Locator_Logger_Was_Resolved()
        {
            var simpleClass = _container.Resolve<ISampleLoggingClass>();

            Assert.IsNotNull(simpleClass.GetLogger());
        }
    }
}
