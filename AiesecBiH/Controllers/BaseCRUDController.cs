using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Model.Search;
using AiesecBiH.Services.BaseServices;
using Microsoft.AspNetCore.Authorization;

namespace AiesecBiH.Controllers
{
    [Authorize]
    public class BaseCRUDController<T,TSearch,TUpdate, TInsert> : BaseReadController<T,TSearch>
        where T: class 
        where TSearch:class 
        where TInsert:class 
        where TUpdate:class
    {
        protected readonly ICRUDService<T, TSearch, TUpdate, TInsert> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TUpdate, TInsert> service):base(service)
        {
            _crudService = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<T> Insert([FromBody] TInsert request=null)
        {
            return await _crudService.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<T> Update(int id,[FromBody] TUpdate request = null)
        {
            return await _crudService.Update(id, request);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<T> Delete(int id)
        {
            return await _crudService.Delete(id);
        }
    }
}
