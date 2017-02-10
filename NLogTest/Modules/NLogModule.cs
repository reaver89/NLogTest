using System.Linq;
using System.Reflection;
using Autofac.Core;
using NLog;
using NLogTest.Logging;
using Module = Autofac.Module;

namespace NLogTest.Modules
{
    public class NLogModule : Module
    {
        private static void InjectLoggerProperties(object instance)
        {
            var instanceType = instance.GetType();

            var properties = instanceType
              .GetProperties(BindingFlags.Public | BindingFlags.Instance)
              .Where(p => p.PropertyType == typeof(ILogAdapter) && p.CanWrite && p.GetIndexParameters().Length == 0);

            foreach (var propToSet in properties)
            {
                propToSet.SetValue(instance, new NLogLogAdapter(LogManager.GetLogger(instanceType.FullName)), null);
            }
        }

        private static void OnComponentPreparing(object sender, PreparingEventArgs e)
        {
            var t = e.Component.Activator.LimitType;
            e.Parameters = e.Parameters.Union(
                new[]
                {
                    new ResolvedParameter((p, i) => p.ParameterType == typeof (ILogAdapter),
                        (p, i) => new NLogLogAdapter(LogManager.GetLogger(t.FullName)))
                });
        }

        protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
        {
            registration.Preparing += OnComponentPreparing;
            registration.Activated += (sender, e) => InjectLoggerProperties(e.Instance);
        }

    }
}
