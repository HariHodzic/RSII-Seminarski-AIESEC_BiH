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
    public class OfficesController : BaseCRUDController<Model.Office, Model.Search.Office, Model.Update.Office, Model.Insert.Office>
    {
        public OfficesController(IOfficeService service):base(service)
        {

        }
    }
}
