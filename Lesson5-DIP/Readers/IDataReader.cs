using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IDataReader
    {
        IEnumerable<Job> Read();
    }
}
