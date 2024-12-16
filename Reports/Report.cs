using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class Report
    {
        // 0. Definice class Report (Datová třída Report - property: header, dataCreated, body)

        public required string Header { get; set; } //TODO: replace required by constructor
        public required DateTime DataCreated { get; set; }
        public required string Body { get; set; }

    }
}
