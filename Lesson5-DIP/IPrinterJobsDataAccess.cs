using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        IEnumerable<Job> GetJobs(IDictionary<string, string> parameters);
    }

    public class SqlDataReader : ISqlDataReader
    {
        private readonly string conenctionString;

        public SqlDataReader(string conenctionString)
        {
            this.conenctionString = conenctionString;
        }

        public IEnumerable<Job> Read()
        {
            return new List<Job>();
        }
    }

    public interface ISqlDataReader
    {
        IEnumerable<Job> Read();
    }

    public class Job
    {
        public string Owner { get; set; }
        public string Content { get; set; }
    }

    public class PrinterJobsDataAccess : IPrinterJobsDataAccess
    {
        private readonly ISqlDataReader sqlDataReader;

        public PrinterJobsDataAccess(ISqlDataReader sqlDataReader)
        {
            this.sqlDataReader = sqlDataReader;
        }

        public IEnumerable<Job> GetJobs(IDictionary<string, string> parameters)
        {
            var data = sqlDataReader.Read();
            return data;
        }

        //TODO DesignPattern "Strategy"
    }
}
