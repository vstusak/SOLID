using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    internal class BaseSalaryLoader : IBaseSalaryLoader

    {
        public int GetBaseSalary()
        {
            return 10000;
        }
    }

    public interface IBaseSalaryLoader
    {
        int GetBaseSalary();
    }

    public class RichBaseSalaryLoader : IBaseSalaryLoader
    {
        public int GetBaseSalary()
        {
            return 50000;
        }
    }

}
