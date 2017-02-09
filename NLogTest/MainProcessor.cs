using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NLogTest.Logging;

namespace NLogTest
{
    public class MainProcessor
    {
        private readonly NetworkProcessor _networkProcessor;
        private readonly ILogAdapter _logger;

        public MainProcessor(NetworkProcessor networkProcessor, ILogAdapter logger)
        {
            _networkProcessor = networkProcessor;
            _logger = logger;
        }

        public void Process()
        {
            _logger.Debug("test");
            var networks = new List<int>() { 1, 2, 3, 4, 5 };

            _logger.Info("Following networks will be processed:{0}", string.Join(",", networks.Select(x => x)));

            _logger.Info("Start networks processing");
            foreach (var network in networks)
            {
                _logger.Info("Start processing {0} network", network);

                var thread = new Thread(_networkProcessor.Process);
                thread.Start();
                _logger.Error("error");
                _logger.Info("Finish processing {0} network", network);
            }
            _logger.Info("Finish networks processing");
        }

    }
}