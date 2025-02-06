using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class ReportFactory
    {
        private readonly IOurDataReader _dataReader;
        private readonly IDateTimeProvider _dateTimeProvider;

        public ReportFactory(IOurDataReader dataReader, IDateTimeProvider dateTimeProvider)
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
            var body = new StringBuilder();
            foreach (var row in data)
            {
                body.AppendLine($"{row.Key} : {row.Value}");
            }

            var report = new Report()
            {
                Header = header,
                DataCreated = createdDate,
                Body = body.ToString()
            };

            return report;
        }
    }

    public class DataReader : IOurDataReader 
    {
        public Dictionary<string,int> GetData()
        {
            var warehouse = new Dictionary<string, int>
            {
                { "rohlik", 5 },
                { "chleba", 10 },
                { "kolac", 3 },
                { "veka", 5 }
            };
            return warehouse;
        }
    }

    public interface IOurDataReader
    {
        Dictionary<string, int> GetData();
    }
}
