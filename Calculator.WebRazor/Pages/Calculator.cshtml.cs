using Calculator.Contracts;
using Calculator.WebApi.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Calculator.WebApp.Razor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        private readonly LocalhostCalculatorApiClient _client;

        [BindProperty]
        public InputData InputData { get; set; } = new InputData();
        public string Result { get; set; }

        public CalculatorModel(ILogger<CalculatorModel> logger, LocalhostCalculatorApiClient localhostCalculatorApiHttpClient)
        {
            _logger = logger;
            //_client = httpClientFactory.CreateClient("CalculatorAPI");
            _client = localhostCalculatorApiHttpClient;
        }

        public void OnGet()
        {
            _logger.LogWarning("We are in Calculator page.");
        }

        //public void OnPostFirst()
        //{
        //    _logger.LogWarning("We are in method First post.");
        //}
        public async Task<IActionResult> OnPostAsync()
        {
      
            if (InputData.Operation == OperationEnum.Div && InputData.Value2 <= 0)
            {
                _logger.LogWarning("Division by zero is not allowed.");
                ModelState.AddModelError(string.Empty, "Division by zero is not allowed.");
            }

            _logger.LogWarning("We are in method post.");
            
            //TODO add validation for value1

            //var client = new HttpClient(); // re  move this hard dependency

            //Port you can find in CalculatorApi project->Properties->launchSettings-> 'http' part
            //client.BaseAddress = new Uri("http://localhost:5062");
            
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is not valid.");
                return Page();
            }
            
            _logger.LogInformation(
                $"[{nameof(InputData.Value1)}] is [{InputData.Value1}], [{nameof(InputData.Operation)}] is [{InputData.Operation}], [{nameof(InputData.Value2)}] is [{InputData.Value2}]");
            
            var response = await _client.GetCalculationResultAsync(InputData);
            Result = response.ToString(CultureInfo.InvariantCulture);
           
            //TODO exception(error response)
            return Page();
        }
    }
}