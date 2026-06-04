using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using Calculator.Contracts;
using Calculator.WebApi.Client;

namespace Calculator.WebApp.Razor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        private readonly LocalhostCalculatorApiClient _client;
        
        [Required]
        [Range(0,100)]
        public int Hodnota1 { get; set; }

        public int Hodnota2 { get; set; }
        public OperationEnum Operand { get; set; }
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
        public async Task OnPostAsync(InputData data)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is not valid.");
                return;
            }
            _logger.LogWarning("We are in method post.");
            _logger.LogInformation(
                $"[{nameof(data.Value1)}] is [{data.Value1}], [{nameof(data.Operation)}] is [{data.Operation}], [{nameof(data.Value2)}] is [{data.Value2}]");
            //TODO create validations, handle errors
            Hodnota1 = (data.Value1); 
            Hodnota2 = (data.Value2);
            Operand = data.Operation;

            //var client = new HttpClient(); // remove this hard dependency
            
            //Port you can find in CalculatorApi project->Properties->launchSettings-> 'http' part
            //client.BaseAddress = new Uri("http://localhost:5062");

            var response = await _client.GetCalculationResultAsync(data);
            Result = response.ToString(CultureInfo.InvariantCulture);
           
            //TODO exception(error response)
        }
    }
}