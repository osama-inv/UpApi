using Microsoft.AspNetCore.Mvc;

namespace UpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        private static readonly string[] PeopleNames = new[]
        {
             "John", "Jane", "Doe", "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller"
        };


        private Person GetPerson()
        {
            var rng = new Random();
            return new Person
            {
                Name = PeopleNames[rng.Next(PeopleNames.Length)],
                Age = rng.Next(18, 65)
            };
        }

        [HttpGet("person")]
        public Person Get()
        {
            return GetPerson();
        }
    }
}
