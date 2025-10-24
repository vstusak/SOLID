using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.WebRazor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        public int Hodnota1 { get; set; }
        public int Hodnota2 { get; set; }
        public string Operand { get; set; }
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
        public void OnPost(string value1, string value2, string operand)
        {
            _logger.LogWarning("We are in method post.");
            _logger.LogInformation($"[{nameof(value1)}] is [{value1}], [{nameof(operand)}] is [{operand}], [{nameof(value2)}] is [{value2}]");
            Hodnota1 = Int32.Parse(value1); //TODO create validations, handle errors
            Hodnota2 = Int32.Parse(value2);
            Operand = operand;

            switch (Operand)  //TODO replace this local POC with an API call. 
            {
                case "+":
                    Result = (Hodnota1 + Hodnota2).ToString();
                    break;
                default:
                    Result = ($"[{nameof(Operand)}] [{Operand}] is not yet supported.");
                    break;
            }
        }
    }
}
