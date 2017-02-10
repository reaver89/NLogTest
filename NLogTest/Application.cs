
using Autofac;
using NLogTest.Logging;

namespace NLogTest
{
    public class Application : IApplication
    {
        private readonly MainProcessor _processor;

        public Application(MainProcessor processor, ILifetimeScope scope)
        {
            _processor = processor;
            scope.Resolve<ILogAdapter>().Info("test");
        }

        public void Run()
        {
            _processor.Process();
        }
    }
}
