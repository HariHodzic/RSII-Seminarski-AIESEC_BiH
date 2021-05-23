using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AiesecBiH.Model.Search;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseReadController<T,TSearch> : ControllerBase 
        where T:class 
        where  TSearch:BaseSearchModel
    {
        protected readonly IReadService<T, TSearch> _service;

        public BaseReadController(IReadService<T,TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual Task<IEnumerable<T>> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public virtual Task<T> GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }
    }
}
