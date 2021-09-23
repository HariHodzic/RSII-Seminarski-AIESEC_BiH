using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;
using Microsoft.AspNetCore.Authorization;
using AiesecBiH.Model.Update;

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

        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<Model.Response.Member>> Get([FromQuery] Model.Search.Member request)
        {
            return await _service.Get(request);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<Model.Response.Member> GetById(int id)
        {
            return await _service.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<Model.Response.Member> Insert([FromBody]Model.Insert.Member member)
        {
            return await _service.Insert(member);
        }
        [Authorize]
        [HttpPost("ChangePassword/{id}")]
        public Task<Model.Response.MemberLL> ChangePassword(int id,[FromBody] ChangePasswordModel model)
        {
            
            return _service.ChangePassword(id, model);
             
        }


        [HttpPut("{id}")]
        public async Task<Model.Response.Member> Update(int id, [FromBody] Model.Update.Member request)
        {
            return await _service.Update(id, request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<Model.Response.Member> Remove(int id)
        {
            return await _service.Remove(id);
        }
        [HttpGet("MyProfile")]
        [Authorize]
        public async Task<Model.Response.MemberLL> MyProfile()
        {
            return await _service.MyProfile();
        }
    }
}
