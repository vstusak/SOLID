using System;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string GetSequenceOfTwenty(string input)
        {
            return GetSequence(input, "20");
        }


        public string GetSequence(string input, string iterationCount)
        {
            string result = string.Empty;
            for (int i = Int32.Parse(input); i < Int32.Parse(iterationCount) + Int32.Parse(input); i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = result + "fizzbuzz ";
                }
                else if (i % 3 == 0)
                {
                    result = result + "fizz ";
                }
                else if (i % 5 == 0)
                {
                    result = result + "buzz ";
                }
                else
                {
                    result = result + i.ToString() + " ";
                }
            }
            return result.Trim();
        }
        public string GetSequenceWithParsing(string input, string iterationCount)
        {
            string result = string.Empty;
            var parsedInput = Int32.Parse(input);
            var parsedIterationCount = Int32.Parse(iterationCount);

            for (int i = parsedInput; i < parsedIterationCount + parsedInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = result + "fizzbuzz ";
                }
                else if (i % 3 == 0)
                {
                    result = result + "fizz ";
                }
                else if (i % 5 == 0)
                {
                    result = result + "buzz ";
                }
                else
                {
                    result = result + i.ToString() + " ";
                }
            }
            return result.Trim();
        }
    }
}


