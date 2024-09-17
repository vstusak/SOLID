using Lesson1_SRP.Calculations;
using Lesson1_SRP.Entities;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationProviderTest
    {
        //given-> when-> then
        public void EmptyList_GetMultiplication_1()
        {
            //arrange
            List<Salary> emptySalaries = new List<Salary>();
            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 1;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(emptySalaries);
            //assert
            Assert.Equal(expectedResult,actualResult, 0.01);

        }
    }
}
