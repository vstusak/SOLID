using System;
using System.Collections.Generic;
using System.Text;

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
        public string GetSequenceWithParsingAndWithList(string input, string iterationCount)
        {
            //string result = string.Empty;
            var parsedInput = Int32.Parse(input);
            var parsedIterationCount = Int32.Parse(iterationCount);

            var list = new List<string>();

            for (int i = parsedInput; i < parsedIterationCount + parsedInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            //return result.Trim();
            return string.Join(" ", list);
        }

        public string GetSequenceWithParsingAndWithStringBuilder(string input, string iterationCount)
        {
            //string result = string.Empty;
            var parsedInput = Int32.Parse(input);
            var parsedIterationCount = Int32.Parse(iterationCount);

            //var list = new List<string>();

            var sb = new StringBuilder();

            for (int i = parsedInput; i < parsedIterationCount + parsedInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.Append("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("fizz");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("buzz");
                }
                else
                {
                    sb.Append(i.ToString());
                }
                sb.Append(" ");
            }
            //return result.Trim();
            //return string.Join(" ", list);
            return sb.ToString().Trim();
        }

        public string GetSequenceWithParsingAndWithPrealocatedStringBuilder(string input, string iterationCount, int capacity)
        {
            //string result = string.Empty;
            var parsedInput = Int32.Parse(input);
            var parsedIterationCount = Int32.Parse(iterationCount);

            //var list = new List<string>();

            var sb = new StringBuilder(capacity);

            for (int i = parsedInput; i < parsedIterationCount + parsedInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.Append("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("fizz");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("buzz");
                }
                else
                {
                    sb.Append(i.ToString());
                }
                sb.Append(" ");
            }
            //return result.Trim();
            //return string.Join(" ", list);
            return sb.ToString().Trim();
        }
    }
}


