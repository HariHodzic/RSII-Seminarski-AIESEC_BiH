using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface IEventService:ICRUDService<Model.Response.Event, Model.Search.Event, Model.Update.Event, Model.Insert.Event>
    {
    }
}
