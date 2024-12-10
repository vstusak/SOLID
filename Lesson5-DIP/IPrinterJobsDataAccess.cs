using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        List<Job> GetJobs(SqlParameterCollection parameters);
    }

    public class PrinterJobsDataAccess: IPrinterJobsDataAccess
    {
        public List<Job> GetJobs(SqlParameterCollection parameters)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class SqlParameterCollection
    {
    }

    public class SqlDataReader
    {
    }

    public class Job// hvězdičky
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
    }
}