using System.ComponentModel.DataAnnotations;

namespace Calculator.Contracts
{
    public class InputData
    {
        public OperationEnum Operation { get; set; } 
        public int Value1 { get; set; }

        [Required]
        [Range(0,10)]
        public int Value2 { get; set; }
    }
}
