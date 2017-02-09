using System.Threading;
using Microsoft.Practices.ServiceLocation;
using NLog;

namespace NLogTest
{
    public class NetworkProcessor
    {
        private int NetworkId { get; set; }

        private ILogAdapter logger;

        public NetworkProcessor(int networkId)
        {
            NetworkId = networkId;
            //FileTarget target = LogManager.Configuration.FindTargetByName<FileTarget>("networkFile");
            //target.FileName = $"network{networkId}_{target.FileName}";
            logger = ServiceLocator.Current.GetInstance<ILogAdapter>();
        }

        public void Process()
        {
            CreateClientDbSchema();
            PopulateClientDb();
            WorkwithDF();
        }

        public void CreateClientDbSchema()
        {
            logger.Debug(" Start schema creation for {0} network", NetworkId);
            Thread.Sleep(1000);
            logger.Error("Exception in creation of schema for {0} network", NetworkId);
            logger.Debug("Finish schema creation for {0} network", NetworkId);
        }

        public void PopulateClientDb()
        {
            logger.Debug(" Start data population for {0} network", NetworkId);
            Thread.Sleep(1000);
            logger.Debug(" Finish data population for {0} network", NetworkId);
        }

        public void WorkwithDF()
        {
            logger.Error(" Errpr during DF recreation {0} ", NetworkId);
            Thread.Sleep(1000);
        }
    }
}