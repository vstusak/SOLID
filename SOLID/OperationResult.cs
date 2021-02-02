namespace SOLID
{
    public class OperationResult : IOperationResult
    {
        private readonly int _value;

        public OperationResult(int value)
        {
            _value = value;
        }

        public int Value { get => _value; }

        public string Description { get; set; }
    }

}
