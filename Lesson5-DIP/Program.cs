using System;

namespace Lesson5_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var jobsDataAccess = new PrinterJobsDataAccess();
            //var jobs = jobsDataAccess.GetJobs();
        }
    }
}