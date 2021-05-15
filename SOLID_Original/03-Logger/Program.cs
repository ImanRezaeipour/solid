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
            var logger = new Logger();
            logger.Log("Starting program...", LogType.Console);

            Console.ReadLine();

        }
    }
}
