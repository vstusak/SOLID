using System;

namespace Lesson5_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CSVDataReader();
            var jobsAcces = new PrinterJobsDataAccess(reader);
            var jobs = jobsAcces.GetJobs(new ParameterCollection());
        }
    }

    
}
