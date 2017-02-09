using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogTest
{
    public class NLogLogAdaper : ILogAdapter
    {
        private readonly Logger _logger;

        public NLogLogAdaper()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public NLogLogAdaper(Logger logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string format, params object[] args)
        {
            _logger.Debug(format, args);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string format, params object[] args)
        {
            _logger.Info(format, args);
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Trace(string format, params object[] args)
        {
            _logger.Trace(format, args);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string format, params object[] args)
        {
            _logger.Error(format, args);
        }
    }
}
