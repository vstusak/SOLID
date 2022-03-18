using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq.Expressions;

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

            Expression<Func<IMultiplicationRulesProvider, double>> expression = mrpm => mrpm.ApplyRules(It.IsAny<IEnumerable<Salary>>(), It.IsAny<double>());

            //multiplicationRulesProviderMock.Setup(mrpm => mrpm.ApplyRules( new List<Salary>(), 0)).Returns(1);
            //multiplicationRulesProviderMock.Setup(mrpm => mrpm.ApplyRules(null, 0)).Returns(1);
            multiplicationRulesProviderMock.Setup(expression).Returns(1);
            //bonusesRulesProviderMock.Setup(brpm => brpm.ApplyRules(null)).Returns(new List<int>());

            //Mock TenantId in mrmp
            //multiplicationRulesProviderMock.Setup(mrmp => mrmp.TenantId).Returns("My Tenant");
            multiplicationRulesProviderMock.SetupProperty(mrmp => mrmp.TenantId, "Initial");
            multiplicationRulesProviderMock.Setup(mrmp => mrmp.TenantAddress.Street.Name).Returns("Vlnena");

            bonusesRulesProviderMock.Setup(brpm => brpm.ApplyRules(It.IsAny<IEnumerable<Salary>>())).Returns(new List<int> { 1, 1, 1 });
            var retirementCalculator = new RetirementCalculator(multiplicationRulesProviderMock.Object, bonusesRulesProviderMock.Object);
            var expectedResult = 10003;
            IEnumerable<Salary> salaries = new List<Salary>();
            IEmployee employee = new Employee();

            //Act
            var actualResult = retirementCalculator.Process(salaries, employee);
            //Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal("My string", multiplicationRulesProviderMock.Object.TenantId);
            //Assert.Equal("Jina adresa", multiplicationRulesProviderMock.Object.TenantAddress.Street.Name);

            multiplicationRulesProviderMock.VerifySet(mrmp => mrmp.TenantId = "My string");
            multiplicationRulesProviderMock.VerifySet(mrmp => mrmp.TenantId = "My string 2", Times.Exactly(2));

            multiplicationRulesProviderMock.Verify(expression);
            //Check for howmany times the method has been called.
            multiplicationRulesProviderMock.Verify(expression, Times.Exactly(1));
        }
    }
}
