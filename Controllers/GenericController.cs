using APICrud.iServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {

        private iGenericService<T> _genericService;

        public GenericController(iGenericService<T> genericService)
        {
            _genericService = genericService;
        }


        [HttpGet]
        public List<T> Get() 
        {
            return _genericService.GetAll();
        }

        [HttpGet("{id}")]
        public T Get(int id) 
        { 
            return _genericService.Get(id);
        }

        //[HttpPost]
        //public List<T> Post([FromBody] T value) {return _genericService.Insert(value);}
    }
}
