using Lesson1_SRP.Calculations;
using Lesson1_SRP.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson1_SRP.Tests.Calculations
{
    public class BonusProviderTest
    {
        [TestCase(50000, 2000)]
        [TestCase(46000, 0)]
        [TestCase(47000, 0)]
        [TestCase(0, 0)]
        public void SalarySentByParameter_GetBonuses_ExpectedResultByParameter(int salaryValue, int expectedResult)
        {
            //arrange
            var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = salaryValue };
            List<Salary> oneSalary = new List<Salary>();
            oneSalary.Add(salary);
            var underTest = new BonusProvider();
            //act
            var actualResult = underTest.GetBonuses(oneSalary).Sum();
            //assert
            NUnit.Framework.Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void EmptyListOfSalaries_GetBonuses_0()
        {
            //arrange
            List<Salary> emptySalaries = new List<Salary>();
            var underTest = new BonusProvider();
            int expectedResult = 0;
            //act
            var actualResult = underTest.GetBonuses(emptySalaries).Sum();
            //assert
            NUnit.Framework.Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}

//salary > 47000 -> bonuses added +2000
//salary < 47000 -> salary stays the same
//salary = 47000 -> salary stays the same
//salary = 0 -> salary stays the same
//TODO: salary with negative value -> salary stays the same
//TODO: List<Salary> salaries = null
//List<Salary> salaries - empty