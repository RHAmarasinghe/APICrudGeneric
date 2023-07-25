using APICrud.iServices;
using APICrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   
    
    public class PersonController : GenericController<Person>
    {
        public PersonController(iGenericService<Person> genericService) : base(genericService) 
        { }
    }
}
