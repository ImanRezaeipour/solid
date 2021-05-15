using System;
using System.Diagnostics;

namespace _03_Logger
{
    public interface ILogger
    {
        void Log(string message, LogType logType);
    }

    public class Logger : ILogger
    {
        public void Log(string message, LogType logType)
        {
            if (logType == LogType.Database)
            {
                //Use EntityFramework to log the file...
            }
            else if (logType == LogType.XmlFile)
            {
                //log in XML File
            }
            else if (logType == LogType.Debug)
            {
                Debug.WriteLine(message);
            }
            else if (logType == LogType.Console)
            {
                Console.WriteLine(message);
            }
        }
    }
}