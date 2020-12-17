namespace SOLID
{
    partial class Program
    {
        public class Div : IOperation
        {
            private readonly int _a;
            private readonly int _b;

            public Div(int a, int b)
            {
                _a = a;
                _b = b;
            }

            public int Execute()
            {
                return _a / _b;
            }
        }

    }
}
