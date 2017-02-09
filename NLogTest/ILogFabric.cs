using System;

namespace NLogTest
{
    public interface ILogFabric
    {
        ILogAdapter GetLogger();
        ILogAdapter GetLogger(string name);
        ILogAdapter GetLogger(string name, Type type);
    }
}