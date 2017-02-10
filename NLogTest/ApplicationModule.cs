using Autofac;
using NLog;
using NLogTest.Logging;

namespace NLogTest
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<MainProcessor>().AsSelf();
            builder.RegisterType<NetworkProcessor>().AsSelf();
        }
    }
}
