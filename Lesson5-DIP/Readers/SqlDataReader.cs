using System.Collections.Generic;

namespace Lesson5_DIP
{
    public class SqlDataReader : IDataReader
    {
        private readonly string _conenctionString;

        public SqlDataReader(string conenctionString)
        {
            _conenctionString = conenctionString;
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }
}
