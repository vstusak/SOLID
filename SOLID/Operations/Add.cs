﻿namespace SOLID
{
    partial class Program
    {
        public class Add : IOperation
        {
            private readonly int _a;
            private readonly int _b;

            public Add(int a, int b)
            {
                _a = a;
                _b = b;
            }

            public int Execute()
            {
                return _a + _b;
            }
        }

    }
}
