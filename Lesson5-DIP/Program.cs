using System;
using System.Collections.Generic;
using System.Threading;

namespace Lesson5_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Owner", "Tomas");

            var path = "https://";

            var readers = new List<IDataReader> {
                //new SqlDataReader(),
                //new FileDataReader(),
                //new ApiDataReader()
            };

            //var printerJobsDataAccess = new PrinterJobsDataAccess(sqlDataReader);

            Thread.Sleep(11);

            //printerJobsDataAccess.DataReader = fileDataReader;

            //var jobs = printerJobsDataAccess.GetJobs(parameters);

            //Console.WriteLine(jobs);
        }
    }
}
