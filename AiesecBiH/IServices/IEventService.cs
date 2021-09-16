using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface IEventService:ICRUDService<Model.Response.Event, Model.Search.Event, Model.Update.Event, Model.Insert.Event>
    {
        Task<Model.Response.EventAttendance> Attend(int id, int memberId);
        bool isAttending(int eventId, int memberId);
        Task<IEnumerable<Model.Response.EventAttendance>> GetAttendance(int id);

    }
}
