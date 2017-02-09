using System.Threading;
using NLogTest.Logging;

namespace NLogTest
{
    public class NetworkProcessor
    {
        public int NetworkId { get; set; }

        private readonly ILogAdapter _logger;

        public NetworkProcessor(ILogAdapter logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            CreateClientDbSchema();
            PopulateClientDb();
            WorkwithDF();
        }

        private void CreateClientDbSchema()
        {
            _logger.Debug(" Start schema creation for {0} network", NetworkId);
            Thread.Sleep(1000);
            _logger.Error("Exception in creation of schema for {0} network", NetworkId);
            _logger.Debug("Finish schema creation for {0} network", NetworkId);
        }

        private void PopulateClientDb()
        {
            _logger.Debug(" Start data population for {0} network", NetworkId);
            Thread.Sleep(1000);
            _logger.Debug(" Finish data population for {0} network", NetworkId);
        }

        private void WorkwithDF()
        {
            _logger.Error(" Errpr during DF recreation {0} ", NetworkId);
            Thread.Sleep(1000);
        }
    }
}