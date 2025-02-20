using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    //1. a) HeaderReader class: Načíst hlavičku - pěknou, obyč.a ugly (nastavení parametrem)
    public class HeaderReader : IHeaderReader
    {
        public string GetHeader(HeaderType headerType)
        {
            switch (headerType)
            {

                case HeaderType.Undefined:
                    throw new Exception();
                case HeaderType.Standard:
                    return "Hello";
                case HeaderType.Colleagues:
                    return "Hi fellows";
                case HeaderType.Employees:
                    return "All";
                case HeaderType.Friends:
                    return "Hi";
                default:
                    throw new ArgumentOutOfRangeException(nameof(headerType), headerType, null);
            }
        }
    }

    public enum HeaderType
    {
        Undefined,
        Standard,
        Colleagues,
        Employees,
        Friends
    }
}
