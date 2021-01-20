using System.Collections.Generic;

namespace Lesson5_DIP
{
    public class FileDataReader : IDataReader
    {
        private readonly string _path;

        public FileDataReader(string path)
        {
            _path = path;
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }
}
