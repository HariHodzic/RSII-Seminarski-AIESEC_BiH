using AiesecBiH.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Controllers
{
    public class NoticesController : BaseCRUDController<Model.Response.Notice, Model.Search.Notice, Model.Update.Notice, Model.Insert.Notice>
    {
        public NoticesController(INoticeService service):base(service)
        {

        }
    }
}
