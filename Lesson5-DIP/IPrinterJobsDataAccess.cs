using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
       // SqlDataReader GetJobs(IDictionary<string, string> parameters);
        IEnumerable<Job> GetJobs(IEnumerable<Parameter> parameters);
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string Condition { get; set; }
    }

    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Content { get; set; }

    }

    public class SqlParameterCollection
    {
    }

    public class SqlDataReader : ISqlDataReader
    {
        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }

    public interface ISqlDataReader
    {
        IEnumerable<Job> Read();
    }

    public class SqlDataAccess : IPrinterJobsDataAccess
    {
        private readonly ISqlDataReader _reader;

        public SqlDataAccess(ISqlDataReader reader)
        {
            _reader = reader;
        }
        public IEnumerable<Job> GetJobs(IEnumerable<Parameter> parameters)
        {
           return _reader.Read();
        }
    }
}