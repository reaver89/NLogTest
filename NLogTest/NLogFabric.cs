using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogTest
{
    public class NLogFabric : ILogFabric
    {
        public ILogAdapter GetLogger()
        {
            return new NLogLogAdaper();
        }

        public ILogAdapter GetLogger(string name)
        {
            return new NLogLogAdaper(name);
        }
    }
}
