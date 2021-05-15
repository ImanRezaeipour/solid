using System;
using System.Diagnostics;
using System.IO;

namespace _01_FileReader
{
    public static class Logger
    {
        public static void WriteToDebug(string message)
        {
            Debug.WriteLine(message);
        }

        public static void WriteToFile(string message, string filename)
        {
            if (!File.Exists(filename))
                File.Create(filename);

            File.AppendAllText(filename,Environment.NewLine + message);
        }
    }
}