using System;
using System.Collections.Generic;

namespace Lesson5_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Owner", "Tomas");

            var sqlDataReader = new SqlDataReader("...GetEnvironmentVariable(connectionString)");
            var printerJobsDataAccess = new PrinterJobsDataAccess(sqlDataReader);

            var jobs = printerJobsDataAccess.GetJobs(parameters);

            Console.WriteLine(jobs);
        }
    }
}
