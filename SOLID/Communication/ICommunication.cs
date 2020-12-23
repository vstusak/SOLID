using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Models;

namespace SOLID.Communication
{
    public interface ICommunication
    {
        Operand CollectUsersOperand();

        Input CollectUsersInputValues();
    }
}
