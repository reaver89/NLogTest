using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NLogTest.Logging;
using NLogTest.Test.LoggingTests;
using NUnit.Framework;

namespace NLogTest.Test
{
    public class NetworkProcessorTests
    {
        private IContainer _container;

        [Test]
        public void Test()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterModule<NLogModule>();
            builder.RegisterType<NetworkProcessor>().AsSelf();

            _container = builder.Build();



            var networkProcessor = _container.Resolve<NetworkProcessor>();
            networkProcessor.Process();

            Assert.NotNull(1);
        }
    }
}
