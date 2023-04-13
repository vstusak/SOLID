using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal interface IAction
    {
        void SetOperator();
        void SetEquation();
        void GetResult();
        void OutputResult();
        void LogHistory();
    }
}