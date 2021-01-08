﻿using System;

namespace SOLID.Util
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

        public void ResetCounter()
        {
            _valueCounter = 0;
        }
    }
}
