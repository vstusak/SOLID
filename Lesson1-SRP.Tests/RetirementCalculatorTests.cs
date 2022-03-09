using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTests
    {
        [Fact]
        public void RetirementCalculator()
        {
            //Arrange

            var multiplicationRulesProviderMock = new Mock<IMultiplicationRulesProvider>(MockBehavior.Strict);
            var bonusesRulesProviderMock = new Mock<IBonusesRulesProvider>(MockBehavior.Strict);

            //multiplicationRulesProviderMock.Setup(mrpm => mrpm.ApplyRules( new List<Salary>(), 0)).Returns(1);
            //multiplicationRulesProviderMock.Setup(mrpm => mrpm.ApplyRules(null, 0)).Returns(1);
            multiplicationRulesProviderMock.Setup(mrpm => mrpm.ApplyRules(It.IsAny<IEnumerable<Salary>>(), It.IsAny<double>())).Returns(1);
            //bonusesRulesProviderMock.Setup(brpm => brpm.ApplyRules(null)).Returns(new List<int>());

            bonusesRulesProviderMock.Setup(brpm => brpm.ApplyRules(It.IsAny<IEnumerable<Salary>>())).Returns(new List<int>{ 1, 1, 1 });
            var retirementCalculator = new RetirementCalculator(multiplicationRulesProviderMock.Object,bonusesRulesProviderMock.Object);
            var expectedResult = 10003;
            IEnumerable<Salary> salaries = new List<Salary>();
            IEmployee employee = new Employee();

            //Act
            var actualResult = retirementCalculator.Process(salaries, employee);
            //Assert
            Assert.Equal(expectedResult, actualResult);

            //Todo: add check for howmany times the method has been called.
            

        }
    }
}
