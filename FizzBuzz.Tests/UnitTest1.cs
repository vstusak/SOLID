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
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator();
            var result = fizzBuzzGenerator.GetSequenceOfTwenty(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            string input = "1";
            string iterationCount = "22";
            string expectedResult = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz fizz 22";

            //Act
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator();
            var result = fizzBuzzGenerator.GetSequence(input, iterationCount);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}