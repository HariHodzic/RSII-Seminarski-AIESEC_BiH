using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;
using AutoMapper.Configuration;

namespace AiesecBiH.Controllers
{
    public class EventController : BaseCRUDController<Model.Response.Event,Model.Search.Event,Model.Update.Event,Model.Insert.Event>
    {
        public EventController(IEventService service):base(service)
        {

        }
    }
}
