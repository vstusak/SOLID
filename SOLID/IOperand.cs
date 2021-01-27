namespace SOLID
{
    public interface IOperand
    {

        public string Name { get; set; }

        public int Value { get; set; }
    }

    public class IntegerOperand : IOperand
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public IntegerOperand(int value)
        {
            Value = value;
        }
    }
}