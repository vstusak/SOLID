using System.Collections.Generic;
using System.IO;
//using System.IO.Abstractions;

namespace Lesson5_DIP
{
    public class PrinterJobsDataAccess : IPrinterJobsDataAccess
    {
        private IDataReader _dataReader;
        //private readonly IFileSystem _fileSystem;

        public PrinterJobsDataAccess(IDataReader dataReader)
        {
            _dataReader = dataReader;
            //_fileSystem = fileSystem;
        }

        public IEnumerable<Jobs> GetJobs(IDictionary<string, string> parameters)
        {
            throw new System.NotImplementedException();
            //var result = File.Open("", FileMode.Open);
            //var result = 
            //    _fileSystem.File.Open(
            //        "", 
            //        FileMode.Open);
        }
    }
}