using System;

namespace Lesson5_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterJobsDataAccess dataAccess = new SqlPrinterJobsDataAccess(new SqlDataReader());
            //dataAccess.GetJobs();
        }
    }
}
