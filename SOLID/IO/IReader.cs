using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IO
{
    public interface IReader
    {
        char ReadCommand();
        double ReadValue();
    }
}
