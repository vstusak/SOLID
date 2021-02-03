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

        public bool CanProcess()
        {
            //check if we can connect to the server
            //meanwhile turning this reader off by default;
            return false;
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }
}
