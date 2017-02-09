using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTest
{
    public interface ILogAdapter
    {
        void Debug(string message);

        void Debug(string format, params object[] args);

        void Info(string message);

        void Info(string format, params object[] args);

        void Trace(string message);

        void Trace(string format, params object[] args);

        void Error(string message);

        void Error(string format, params object[] args);
    }
}
