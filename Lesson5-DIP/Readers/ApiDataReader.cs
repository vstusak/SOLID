using System.Collections.Generic;

namespace Lesson5_DIP
{
    public class ApiDataReader : IDataReader
    {
        private readonly string _URL;

        public ApiDataReader(string URL)
        {
            _URL = URL;
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }
}
