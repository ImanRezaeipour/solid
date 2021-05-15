using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_FileReader.Caching;
using _01_FileReader.File;
using _01_FileReader.Logging;

namespace _01_FileReader
{
    public class FileStorage
    {
        private readonly ILogger _logger;
        private readonly ICacheManager _cacheManager;
        private readonly IFileReader _fileReader;
        public FileStorage(ILogger logger, ICacheManager cacheManager, IFileReader fileReader)
        {
            _logger = logger;
            this._cacheManager = cacheManager;
            this._fileReader = fileReader;
        }

        public string Read(string filepath)
        {
            if (_cacheManager.Contains(filepath))
            {
                _logger.Log(string.Format("File '{0}' returned from cache.", filepath));
                return _cacheManager.Get(filepath);
            }

            var content = "";
            try
            {
                content = _fileReader.Read(filepath);
            }
            catch (FileNotFoundException ex)
            {
                _logger.Log(string.Format("File '{0}' not found", filepath));
                throw;
            }

            _logger.Log(string.Format("Reading file '{0}' from hard disk.", filepath));
            _cacheManager.AddOrUpdate(filepath,content);
            return content;
        }
    }
}
