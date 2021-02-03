using System;
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

        public bool CanProcess()
        {
            try
            {
                var uri = new Uri(_URL);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Job> Read()
        {
            throw new NotImplementedException();
        }
    }
}
