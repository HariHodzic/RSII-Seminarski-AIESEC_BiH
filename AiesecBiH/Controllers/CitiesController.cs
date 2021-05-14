using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services;
using AiesecBiH.IServices;

namespace AiesecBiH.Controllers
{
    public class CitiesController : BaseCRUDController<Model.City, Model.Search.City, Model.Update.City, Model.Insert.City>
    {
        public CitiesController(ICityService _service):base(_service)
        {
            
        }
    }
}
