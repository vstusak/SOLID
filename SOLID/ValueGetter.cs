using System;

namespace SOLID
{
    public class ValueGetter
    {
        private int _valueCounter;

        public int PromptForValue()
        {
            _valueCounter++;
            Console.WriteLine($"Set value {_valueCounter}:");
            var valueString = Console.ReadLine();
            return int.Parse(valueString ?? "0");
        }
    }
}
