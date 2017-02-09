using System;

namespace NLogTest
{
    public interface ILogFabric
    {
        ILogAdapter GetLogger();
        ILogAdapter GetLogger(string name);
    }
}