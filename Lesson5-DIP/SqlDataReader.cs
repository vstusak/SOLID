using System.Collections.Generic;
using System.IO;

namespace Lesson5_DIP
{
    public class SqlDataReader : IDataReader
    {
        public SqlDataReader(string connectionString)
        {
            //db
        }

        public IEnumerable<Jobs> Read()
        {
            throw new System.NotImplementedException();
        }
    }

    public class FileDataReader : IDataReader
    {
        private readonly string _path;

        public FileDataReader(string path)
        {
            _path = path;
        }

        public IEnumerable<Jobs> Read()
        {
            var result = File.ReadAllLines(_path);
            return ParseData(result);
        }

        private IEnumerable<Jobs> ParseData(string[] data)
        {
            var collection = new List<Jobs>();

            foreach (var row in data)
            {
                // uber logic for data transformation
                //collection.Add(transformed data)    
            }
            return collection;
        }
    }

    public interface IDataReader
    {
        IEnumerable<Jobs> Read();
    }
}