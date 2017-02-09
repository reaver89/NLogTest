using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using NLog;


namespace NLogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureContainer();


            ILogAdapter logger = ServiceLocator.Current.GetInstance<ILogAdapter>();

            logger.Debug("test");
            var networks = new List<int>() { 1, 2, 3, 4, 5 };

            logger.Info("Following networks will be processed:{0}", string.Join(",", networks.Select(x => x)));

            logger.Info("Start networks processing");
            foreach (var network in networks)
            {

                logger.Info("Start processing {0} network", network);
                var networkProcessor = new NetworkProcessor(network);
                var thread = new Thread(networkProcessor.Process);
                thread.Start();
                logger.Error("error");
                logger.Info("Finish processing {0} network", network);

            }
            logger.Info("Finish networks processing");
        }

        private static void ConfigureContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<ILogAdapter>(new InjectionFactory(f => new NLogLogAdaper(LogManager.GetCurrentClassLogger())));
            var locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
