using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileReader.Logging
{
    public static class LoggerFactory
    {
        private static long index = 0;
        public static ILogger Create()
        {
            //index++;
            //if (index % 2 == 0)
            //    return new XmlLogger();
            //else
            //    return  new DatabaseLogger();

            var current = ConfigurationManager.AppSettings["LogType"];
            if (current == null) throw new ConfigurationErrorsException("LogType is not available in configurations.");

            if (string.Equals("xml", current, StringComparison.OrdinalIgnoreCase))
            {
                return new XmlLogger();
            }
            else if (string.Equals("database", current, StringComparison.OrdinalIgnoreCase))
            {
                return new DatabaseLogger();
            }
            else
                throw new ConfigurationErrorsException("Invalid log type in configurations.");
        }
    }
}
