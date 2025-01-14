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
        private readonly IDateTimeProvider _dateTimeProvider;

        public ReportFactory(DataReader dataReader, IDateTimeProvider dateTimeProvider)
        {
            _dataReader = dataReader;
            _dateTimeProvider = dateTimeProvider;
        }

        public Report CreateReport(HeaderType headerType)
        {
            //TODO: before using dependency injection try to write some test
            var headerReader = new HeaderReader();

            string header = headerReader.GetHeader(headerType);
            DateTime createdDate = _dateTimeProvider.UtcNow;

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
