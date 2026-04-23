using Microsoft.Extensions.DependencyInjection;

namespace Calculator.WebApi.Client
{
    public static class Extensions
    {
        //TODO: repeat implementation of fluent
        public static IServiceCollection AddCalculatorApiClients(this IServiceCollection services)
        {
            services.AddHttpClient<LocalhostCalculatorApiClient>();
            return services;
        }
    }
}


//TODO class method class params in method parameters





//TODO: vysvětlit si rows collection. proč bychom měli kolekci objektů zabalit do nadřazené třídy




//TODO: we finished with factory, show example and refactor for builder
//TODO: we should finish with something like this: rowsBuilder.WithUserRows().WithProjectRows().WithTaskRows().GetRows()
//great example suggestion - factory GetRows and get specific rows with various types