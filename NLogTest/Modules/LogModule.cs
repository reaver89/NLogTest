using Autofac;
using NLogTest.Modules;

namespace NLogTest.Logging.Modules
{
    public class LogModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<NLogModule>();
            builder
                .Register(context => new NLogLogAdapter())
                .As<ILogAdapter>()
                .SingleInstance();
        }
    }
}
