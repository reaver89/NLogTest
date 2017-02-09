using Autofac;

namespace NLogTest.Logging
{
    public class LogModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<NLogModule>();
            builder.RegisterType<NLogLogAdaper>().As<ILogAdapter>();
        }
    }
}
