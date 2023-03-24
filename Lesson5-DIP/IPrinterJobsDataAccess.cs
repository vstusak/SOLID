using System;
using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        IEnumerable<Job> GetJobs(ParameterCollection parameters);
    }

    public interface IDataReader
    {
        IEnumerable<Job> Read();
    }

    public class ParameterCollection
    {
    }

    public class SqlDataReader : IDataReader
    {
        public IEnumerable<Job> Read()
        {
            throw new NotImplementedException();
        }
    }

    public class CSVDataReader : IDataReader
    {
        public IEnumerable<Job> Read()
        {
            throw new NotImplementedException();
        }
    }

    public class PrinterJobsDataAccess : IPrinterJobsDataAccess
    {
        private readonly IDataReader _reader;

        public PrinterJobsDataAccess(IDataReader reader)
        {
            _reader = reader;
        }
        public IEnumerable<Job> GetJobs(ParameterCollection parameters)
        {
            return _reader.Read();
        }
    }

    public class Job
    {
        public string Name { get; set; }
    }
}