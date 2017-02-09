using Autofac;
using NLogTest.Logging;

namespace NLogTest
{
    class Program
    {

        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            RegisterComponents();

            using (var scope = Container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }

        }

        private static void RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<LogModule>();
            builder.RegisterModule<ApplicationModule>();

            Container = builder.Build();
        }
    }
}
