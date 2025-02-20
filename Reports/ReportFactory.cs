using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class ReportFactory
    {
        private readonly IOurDataReader _dataReader;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IHeaderReader _headerReader;


        public ReportFactory(IOurDataReader dataReader, IDateTimeProvider dateTimeProvider, IHeaderReader headerReader)
        {
            _dataReader = dataReader;
            _dateTimeProvider = dateTimeProvider;
            _headerReader = headerReader;
        }

        public Report CreateReport(HeaderType headerType)
        {
            string header = _headerReader.GetHeader(headerType);
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

    public interface IHeaderReader
    {
        string GetHeader(HeaderType headerType);
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
