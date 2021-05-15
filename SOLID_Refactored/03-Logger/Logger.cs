using System;
using System.Diagnostics;

namespace _03_Logger
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class XmlLogger : ILogger
    {
        public void Log(string message)
        {
            //....
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            //....
            
        }
    }

    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}