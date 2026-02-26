using System.Net.Http.Json;
using Calculator.Contracts;

namespace Calculator.WebApi.Client
{
    public class LocalhostCalculatorApiClient
    {
        private readonly HttpClient _httpClient;

        public LocalhostCalculatorApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("http://localhost:5062");
        }

        public async Task<double> GetCalculationResultAsync(InputData inputData)
        {
            var response = await _httpClient.PostAsJsonAsync<InputData>("/Calculator", inputData);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            return await response.Content.ReadFromJsonAsync<double>();
        }
    }
}
//DONE - First option NOT to do: - we can reveal http client directly for usage 
//DONE - Implement POST method (follow MS example - https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-10.0)