using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    internal class ApplicationInputValidator
    {
        public bool ValidateInputArguments(string[] args)
        {
            if (args.Length != 1)
            {
                return false;
            }

            if (!File.Exists(args.First()))
            {
                return false;
            }
            return true;
        }
    }
}
