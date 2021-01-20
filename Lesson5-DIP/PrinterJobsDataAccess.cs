using System.Collections.Generic;

namespace Lesson5_DIP
{
    public class PrinterJobsDataAccess : IPrinterJobsDataAccess
    {
        public IDataReader DataReader { get; set; }

        public PrinterJobsDataAccess(IDataReader dataReader)
        {
            DataReader = dataReader;
        }

        public IEnumerable<Job> GetJobs(IDictionary<string, string> parameters)
        {
            var data = DataReader.Read();
            return data;
        }

        //TODO DesignPattern "Strategy"
    }
}
