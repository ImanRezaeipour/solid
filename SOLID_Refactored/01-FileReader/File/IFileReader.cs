using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileReader.File
{
    public interface IFileReader
    {
        string Read(string filePath);
    }
}
