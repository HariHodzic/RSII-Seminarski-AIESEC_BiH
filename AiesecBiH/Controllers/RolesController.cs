using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.Controllers
{
    public class RolesController : BaseReadController<Model.Response.Role,Model.Search.Role>
    {
        
        public RolesController(IReadService<Model.Response.Role, Model.Search.Role> service):base(service)
        {
            
        }
    }
}
