using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        IEnumerable<Jobs> GetJobs(IDictionary<string, string> parameters);
    }
}