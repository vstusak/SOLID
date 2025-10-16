using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.WebRazor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        public string Hodnota1 { get; set; }

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
        public void OnPost(string value1)
        {
            _logger.LogWarning("We are in method post.");
            _logger.LogInformation($"Value 1 is {value1}");
            Hodnota1=value1;
        }
    }
}
