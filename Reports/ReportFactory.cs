using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class ReportFactory
    {
        private readonly DataReader _dataReader;

        public ReportFactory(DataReader dataReader)
        {
            _dataReader = dataReader;
        }

        public Report CreateReport()
        {
            //TODO: finish headerReader parameter to select type
            //TODO: before using dependency injection try to write some test
            var headerReader = new HeaderReader();
            string header = headerReader.GetHeader();
            DateTime createdDate = DateTime.UtcNow;

            var data = _dataReader.GetData();
            //TODO: resolve converision between data and body
            string body = "světe";

            var report = new Report()
            {
                Header = header,
                DataCreated = createdDate,
                Body = body
            };

            return report;
        }
    }

    public class DataReader
    {
        public Dictionary<string,int> GetData()
        {
            return new Dictionary<string, int>();
        }
    }
}
