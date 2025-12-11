namespace Calculator.WebRazor
{
    public class LocalhostCalculatorApiHttpClient
    {
        private readonly HttpClient _httpClient;

        public LocalhostCalculatorApiHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("http://localhost:5062");
        }
    }
}
//TODO - First option NOT to do: - we can reveal http client directly for usage 
//TODO - Implement POST method (follow MS example - https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-10.0)