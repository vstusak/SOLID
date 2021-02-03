using System.Collections.Generic;

namespace Lesson5_DIP
{
    public interface IDataReader
    {
        bool CanProcess();
        IEnumerable<Job> Read();
    }
}
