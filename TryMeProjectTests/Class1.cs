using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferenceTests;

namespace TryMeProjectTests
{
    public class Class1
    {
        public void TryMeTest()
        {
            var unitUnderTest = new TryMe();
            unitUnderTest.Execute();
        }
    }
}
