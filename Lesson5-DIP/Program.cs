using System;
using System.Collections.Generic;
using System.Linq;
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


            

            var reader = DataReaderFactory.GetSuitableDataReader(path);

            var printerJobsDataAccess = new PrinterJobsDataAccess(reader);

            Thread.Sleep(11);

            //printerJobsDataAccess.DataReader = fileDataReader;

            var jobs = printerJobsDataAccess.GetJobs(parameters);

            Console.WriteLine(jobs);
        }
    }

    public class DataReaderFactory
    {
        internal static IDataReader GetSuitableDataReader(string path)
        {
            var readers = new List<IDataReader> { new ApiDataReader(path), new SqlDataReader(path), new FileDataReader(path)};

            return readers.SingleOrDefault(r => r.CanProcess()) ?? new NullDataReader(path);
        }
    }

    public class NullDataReader : IDataReader
    {
        private readonly string path;

        public NullDataReader(string path)
        {
            this.path = path;
        }

        public bool CanProcess()
        {
            return true;
        }

        public IEnumerable<Job> Read()
        {
            //uber logging with information about path
            return new List<Job>();
        }
    }
}
