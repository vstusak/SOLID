using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IOperation
    {
        string Add(InputModel inputModel);
        string Sub(InputModel inputModel);
        string Mul(InputModel inputModel);
        string Div(InputModel inputModel);

    }
}
