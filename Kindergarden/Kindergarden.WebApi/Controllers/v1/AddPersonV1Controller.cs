using Kindergarden.Contracts;
using Kindergarden.Core;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarden.WebApi.Controllers.v1
{
    //NOTE:Control name of endpoint, class name (also for different namespaces) and route for different versions of API
    [ApiController]
    [Route("/api/v1/AddPerson")]
    public class AddPersonV1Controller : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public AddPersonV1Controller(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost(Name = "AddPersonV1")]
        public async Task<Person> Post([FromBody] Person person)
        {
            var result = await _personRepository.AddPersonAsync(person);
            return result;
        }

    }
}
