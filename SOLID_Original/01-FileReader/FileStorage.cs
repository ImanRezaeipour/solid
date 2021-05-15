using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileReader
{
    public class FileStorage
    {
        private string logFile = @"C:\log.txt";
        private static Dictionary<string, string> _cache = new Dictionary<string, string>(); 
        public string Read(string filepath)
        {
            if (_cache.ContainsKey(filepath))
            {
                Logger.WriteToFile(string.Format("File '{0}' returned from cache.", filepath),logFile);
                return _cache[filepath];
            }

            if (!File.Exists(filepath))
            {
                Logger.WriteToFile(string.Format("File '{0}' not found", filepath), logFile);
                throw new FileNotFoundException();
            }

            Logger.WriteToFile(string.Format("Reading file '{0}' from hard disk.", filepath), logFile);
            var content = File.ReadAllText(filepath);
            _cache.Add(filepath,content);

            return content;
        }
    }
}
