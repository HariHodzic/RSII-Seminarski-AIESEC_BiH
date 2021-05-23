using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;

namespace AiesecBiH.Services
{
    public class EventService: CRUDService<Model.Response.Event,Database.Event, Model.Search.Event, Model.Update.Event, Model.Insert.Event>,IEventService
    {
        public EventService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
        }
    }
}
