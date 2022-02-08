using System;
using System.Collections.Generic;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationProviderTests
    {
        public void ThreeSalariesLessThan30000DefaultMultiplcation01_ApplyRules_FinalMultiplication01()
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();
            double defaultMultiplication = 0.1;
            var listOfSalaries = new List<Salary> {   
                new Salary{ DateTime = DateTime.Now, Value = 25000 },
                new Salary{ DateTime = DateTime.Now, Value = 25000 },
                new Salary{ DateTime = DateTime.Now, Value = 25000 }
            };
            //Act
            var finalMultiplication = underTest.ApplyRules(defaultMultiplication,listOfSalaries);
            //Assert
            Assert.
        }

    }
}
