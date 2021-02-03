using System.Collections.Generic;
using System.IO;

namespace Lesson5_DIP
{
    public class FileDataReader : IDataReader
    {
        private readonly string _path;

        public FileDataReader(string path)
        {
            _path = path;
        }

        public bool CanProcess()
        {
            return File.Exists(_path);
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }
}
