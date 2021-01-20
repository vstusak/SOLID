using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        IDataReader DataReader { get; set; }

        IEnumerable<Job> GetJobs(IDictionary<string, string> parameters);
    }
}
