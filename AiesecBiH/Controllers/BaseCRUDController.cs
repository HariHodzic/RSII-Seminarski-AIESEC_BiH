﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.Controllers
{
    public class BaseCRUDController<T,TSearch,TUpdate, TInsert> : BaseReadController<T,TSearch>
        where T: class 
        where TSearch:class 
        where TInsert:class 
        where TUpdate:class
    {
        protected readonly ICRUDService<T, TSearch, TUpdate, TInsert> _crudService;
        public BaseCRUDController(ICRUDService<T,TSearch,TUpdate,TInsert> service):base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public T Insert([FromBody] TInsert request=null)
        {
            return _crudService.Insert(request);
        }

        //[HttpPut("{id}")]
        //public T Update([FromQuery] int id, TUpdate request=null)
        //{
        //    return _crudService.Update(id, request);
        //}
    }
}