using System;

namespace SOLID.Util
{
    public class GetOperand
    {
        public int PromptValue()
        {
            Console.WriteLine($"Choose operand.");
            var valueText = Console.ReadLine();
            if (valueText.Equals(string.Empty)) valueText = "0";
            return int.Parse(valueText);
        }
    }
}
