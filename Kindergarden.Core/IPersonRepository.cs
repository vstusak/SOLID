using Kindergarden.Contracts;

namespace Kindergarden.Core
{
    public interface IPersonRepository
    {
        Task<Person> AddPersonAsync(Person person);
    }

    public class PersonRepository : IPersonRepository
    {
       
        public async Task<Person> AddPersonAsync(Person person)
        {
            //TODO: implement logic to add person to the database or any storage (Entity framework)
            return person;
        }
    }
}
