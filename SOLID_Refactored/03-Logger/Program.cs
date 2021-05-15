using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerFactory.Create();
            logger.Log("Starting program...");

            Console.ReadLine();

        }
    }
}
