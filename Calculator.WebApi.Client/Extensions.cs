using Microsoft.Extensions.DependencyInjection;

namespace Calculator.WebApi.Client
{
    public static class Extensions
    {
        public static IServiceCollection AddCalculatorApiClients(this IServiceCollection services)
        {
            services.AddHttpClient<LocalhostCalculatorApiClient>();
            //TODO: repeat implementation of fluent
            //TODO: vysvětlit si rows collection. proč bychom měli kolekci objektů zabalit do nadřazené třídy
            //TODO class method class params in method parameters
            //TODO: we finished with factory, show example and refactor for builder
            //great example suggestion - factory GetRows and get specific rows with various types
            //TODO: we should finish with something like this: rowsBuilder.WithUserRows().WithProjectRows().WithTaskRows().GetRows()
            return services;
        }
    }
}
