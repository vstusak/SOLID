namespace Calculator.Contracts
{
    public class InputData
    {
        public InputData(int value1, int value2, OperationEnum operation)
        {
            Value1 = value1;
            Value2 = value2;
            Operation = operation;
        }
        public OperationEnum Operation { get; set; } 
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }
}
