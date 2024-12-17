using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class ReportFactory
    {
        public Report CreateReport()
        {
          
            string header = string.Empty;
            DateTime createdDate = DateTime.UtcNow;
            string body = string.Empty;

            var report = new Report()
            {
                Header = header,
                DataCreated = createdDate,
                Body = body
            };

            return report;
        }
    }
}
