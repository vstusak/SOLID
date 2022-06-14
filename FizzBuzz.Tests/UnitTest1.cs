using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            string input = "1";
            string expectedResult = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz";

            //Act
            

            //Assert
            Assert.Pass();
        }
    }
}