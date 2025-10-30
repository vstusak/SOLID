using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Calculator.WebRazor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        public int Hodnota1 { get; set; }
        public int Hodnota2 { get; set; }
        public OperationEnum Operand { get; set; }
        public string Result { get; set; }

        public CalculatorModel(ILogger<CalculatorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogWarning("We are in Calculator page.");
        }

        //public void OnPostFirst()
        //{
        //    _logger.LogWarning("We are in method First post.");
        //}
        public void OnPost(StupidInputData data)
        {
            _logger.LogWarning("We are in method post.");
            _logger.LogInformation(
                $"[{nameof(data.Value1)}] is [{data.Value1}], [{nameof(data.Operand)}] is [{data.Operand}], [{nameof(data.Value2)}] is [{data.Value2}]");
            Hodnota1 = (data.Value1); //TODO create validations, handle errors
            Hodnota2 = (data.Value2);
            Operand = data.Operand;

            switch (Operand) //TODO replace this local POC with an API call. 
            {
                case OperationEnum.Add:
                    Result = (Hodnota1 + Hodnota2).ToString();
                    break;
                default:
                    Result = ($"[{nameof(Operand)}] [{Operand}] is not yet supported.");
                    break;
            }
        }
    }

    public class StupidInputData
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public OperationEnum Operand { get; set; }

    }

    public enum OperationEnum
    {
        Undefined,
        [Description("+")] Add,
        [Description("-")] Sub,
        [Description("*")] Mult,
        [Description("/")] Div
    }
}
