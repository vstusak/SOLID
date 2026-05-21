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

//DONE: vysvětlit si rows collection. proč bychom měli kolekci objektů zabalit do nadřazené třídy
//TODO: pobavit se okolo datových typu okolo enumu + ukázka z FNZ
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

    public class RowsCollection : List<Row>
    {
        public List<Row> GetUserRows()
        {
            return this.Where(r => r.Type == "User").ToList() as RowsCollection;
        }
        public new void Add(Row row)
        {
            if (this.Any(r => r.Id == row.Id))
            {
                throw new Exception("Row with the same Id already exists.");
            }
            base.Add(row);
        }

    }

    public class RowsCollectionIntern
    {
        private readonly List<Row> _rows = [];

        public RowsCollectionIntern()
        {
            _rows = new List<Row>();
        }

        public List<Row> GetUserRows()
        {
            return _rows.Where(r => r.Type == "User").ToList() as RowsCollection;
        }
        public void Add(Row row)
        {
            _rows.Add(row);
        }

    }

    public class Program
    {
        public static void Main()
        {
            var rowsCollection = new RowsCollection();
            var userRows = rowsCollection.GetUserRows();
            rowsCollection.Add(new Row() { Id = 1, Name = "John", Type = "User", CreatedAt = DateTime.Now });



            var rowsCollectionIntern = new RowsCollectionIntern();
            var userRowsIntern = rowsCollectionIntern.GetUserRows();
            rowsCollectionIntern.Add(new Row() { Id = 2, Name = "Jane", Type = "User", CreatedAt = DateTime.Now });
        }
    }
}