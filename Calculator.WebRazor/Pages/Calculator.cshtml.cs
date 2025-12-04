using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Globalization;
using Calculator.Contracts;

namespace Calculator.WebRazor.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        public int Hodnota1 { get; set; }
        public int Hodnota2 { get; set; }
        public OperationEnum Operand { get; set; }
        public string Result { get; set; }

        public CalculatorModel(ILogger<CalculatorModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
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
            _logger.LogWarning("We are in method post.");
            _logger.LogInformation(
                $"[{nameof(data.Value1)}] is [{data.Value1}], [{nameof(data.Operation)}] is [{data.Operation}], [{nameof(data.Value2)}] is [{data.Value2}]");
            Hodnota1 = (data.Value1); //TODO create validations, handle errors
            Hodnota2 = (data.Value2);
            Operand = data.Operation;

            //var client = new HttpClient(); // remove this hard dependency
            var client = _httpClientFactory.CreateClient("CalculatorAPI");

            //Port you can find in CalculatorApi project->Properties->launchSettings-> 'http' part
            //client.BaseAddress = new Uri("http://localhost:5062");

            var response = await client.PostAsJsonAsync<InputData>("/Calculator",data);
            var resultResponse = await response.Content.ReadFromJsonAsync<double>();
            Result = resultResponse.ToString(CultureInfo.InvariantCulture);
           
            //TODO exception(error response)
        }
    }
}