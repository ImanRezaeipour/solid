using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileReader.Caching
{
    public interface ICacheManager
    {
        void AddOrUpdate(string key, string value);
        bool Contains(string key);
        string Get(string key);
    }
}
