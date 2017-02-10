using Autofac;
using NLogTest.Logging;
using NUnit.Framework;

namespace NLogTest.Test.LoggingTests
{

    public class NLogModuleTest
    {
        private IContainer _container;

        [SetUp]
        public void  SetUp()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<NLogModule>();
            builder.RegisterType<SimpleClassWithContructorInjection>().AsSelf();
            builder.RegisterType<SimpleClassWithLoggerProperty>().AsSelf();
            _container = builder.Build();
        }

        [Test]
        public void NLogModule_Constructor_Injection_Resolved()
        {
            var simpleClass = _container.Resolve<SimpleClassWithContructorInjection>();

            Assert.IsNotNull(simpleClass.Logger);
        }

        [Test]
        public void NLogModule_Property_Injection_Resolved()
        {
            var simpleClass = _container.Resolve<SimpleClassWithLoggerProperty>();

            Assert.IsNotNull(simpleClass.Logger);
        }
    }
}
