using Autofac;
using NLogTest.Modules;
using NLogTest.Test.LoggingTests.Common;
using NUnit.Framework;

namespace NLogTest.Test.LoggingTests
{
    [TestFixture]
    public class NLogModuleTest
    {
        private IContainer _container;

        [OneTimeSetUp]
        public void  SetUp()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<NLogModule>();
            builder.RegisterType<SampleClassWithContructorInjection>().AsSelf();
            builder.RegisterType<SampleClassWithLoggerProperty>().AsSelf();

            _container = builder.Build();
        }

        [Test]
        public void NLogModule_Constructor_Injection_Resolved()
        {
            var simpleClass = _container.Resolve<SampleClassWithContructorInjection>();

            Assert.IsNotNull(simpleClass.Logger);
        }

        [Test]
        public void NLogModule_Property_Injection_Resolved()
        {
            var simpleClass = _container.Resolve<SampleClassWithLoggerProperty>();

            Assert.IsNotNull(simpleClass.Logger);
        }
    }
}
