using Microsoft.Extensions.DependencyInjection;

namespace Calculator.WebApi.Client
{
    public static class Extensions
    {
        public static IServiceCollection AddCalculatorApiClients(this IServiceCollection services)
        {
            services.AddHttpClient<LocalhostCalculatorApiClient>();
            //TODO: repeat implementation of fluent
            return services;
        }
    }
}
