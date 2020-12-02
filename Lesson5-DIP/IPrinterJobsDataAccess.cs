using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        IEnumerable<Jobs> GetJobs(IDictionary<string, string> parameters);
    }

    public class Jobs
    {
    }

    public class SqlParameterCollection
    {
    }

    public class SqlDataReader
    {
    }

    public class PrinterJobsDataAccess : IPrinterJobsDataAccess
    {
        private SqlDataReader _dataReader;

        public PrinterJobsDataAccess(SqlDataReader dataReader)
        {
            _dataReader = dataReader;
        }

        public IEnumerable<Jobs> GetJobs(IDictionary<string, string> parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}