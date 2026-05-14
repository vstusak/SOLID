using Microsoft.Extensions.DependencyInjection;

namespace Calculator.WebApi.Client
{
    public static class Extensions
    {
        //DONE: repeat implementation of fluent
        public static IServiceCollection AddCalculatorApiClients(this IServiceCollection services)
        {
            services.AddHttpClient<LocalhostCalculatorApiClient>();
            return services;
        }
    }
}


//TODO class method class params in method parameters

//TODO: vysvětlit si rows collection. proč bychom měli kolekci objektů zabalit do nadřazené třídy
//TODO: pobavit se okolo datových typu okolo enumu
//DONE: we finished with factory, show example and refactor for builder
//DONE: we should finish with something like this: rowsBuilder.WithUserRows().WithProjectRows().WithTaskRows().GetRows()
//great example suggestion - factory GetRows and get specific rows with various types

namespace Testing
{
    public class Row()
    {
        public int Id;
        public string Name;
        public string Type;
        public DateTime CreatedAt;
    }
    public class RowsCollection:List<Row>
    {
        public List<Row> GetUserRows()
        {
            return this.Where(r=>r.Type == "User").ToList() as RowsCollection;
        }

    }
}