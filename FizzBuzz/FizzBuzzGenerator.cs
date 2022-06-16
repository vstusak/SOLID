using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string GetSequenceOfTwenty(string input)
        {
            string result = string.Empty;
            for (int i = Int32.Parse(input); i < 20 + Int32.Parse(input); i++)
            {
                if (i % 3 == 0)
                {
                    result = result + "fizz";
                }
                else
                {
                    result = result + i.ToString();
                }
            }
            return result;
        }
    }
}
