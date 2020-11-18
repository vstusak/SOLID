using System.Collections.Generic;

namespace Lesson1_SRP
{
    //public enum EmployeType
    //{
    //    Employee,
    //    CEO,
    //    Manager
    //}

    public interface IBonusesRulesProvider
    {
        IEnumerable<int> ApplyRules(IEnumerable<Salary> salaries);
    }

}

