using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;
using Microsoft.AspNetCore.Authorization;

namespace AiesecBiH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _service;

        public MembersController(IMemberService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Model.Response.Member>> Get([FromQuery] Model.Search.Member request)
        {
            return await _service.Get(request);
        }

        [HttpGet("{id}")]
        public async Task<Model.Response.Member> GetById(int id)
        {
            return await _service.GetById(id);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<Model.Response.Member> Insert([FromBody]Model.Insert.Member member)
        {
            return await _service.Insert(member);
        }
        
        [HttpPut("{id}")]
        public async Task<Model.Response.Member> Update(int id, [FromBody] Model.Update.Member request)
        {
            return await _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public async Task<Model.Response.Member> Remove(int id)
        {
            return await _service.Remove(id);
        }
    }
}
