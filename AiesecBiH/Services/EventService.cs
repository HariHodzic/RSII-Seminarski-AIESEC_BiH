using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class EventService: CRUDService<Model.Response.Event,Database.Event, Model.Search.Event, Model.Update.Event, Model.Insert.Event>,IEventService
    {
        public EventService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
        }

        public async Task<EventAttendance> Attend(int id, int memberId)
        {
            Database.EventAttendance request = new Database.EventAttendance
            {
                EventId = id,
                MemberId = memberId,
                Attended = true,
                CreatedDate=DateTime.Now
            };
            await _context.EventAttendances.AddAsync(request);
            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.EventAttendance>(request);
        }

        public override async Task<IEnumerable<Model.Response.Event>> Get([FromQuery] Model.Search.Event search = null)
        {
            var query = _context.Events.AsQueryable();
            if (search?.InPast == false)
            {
                query = query.Where(x => DateTime.Compare(x.DateTime,DateTime.Now)>0);
            }
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name));
            }
            if (search?.onlyActive != null && search.onlyActive == true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            if (search?.LocalCommitteeId != null && search?.LocalCommitteeId!=0 )
            {
                query = query.Where(x => x.LocalCommitteeId == search.LocalCommitteeId);
            }
            if (search?.FunctionalFieldId != null && search?.FunctionalFieldId != 0 )
            {
                query = query.Where(x => x.FunctionalFieldId == search.FunctionalFieldId);
            }
            query = query.Where(x => x.Id != 1);
            var entities = await query.Include(x=>x.FunctionalField).Include(x=>x.LocalCommittee).OrderByDescending(x=>x.DateTime).ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.Event>>(entities);
            return result;
        }

        public async Task<IEnumerable<Model.Response.EventAttendance>> GetAttendance(int id)
        {
           var result= await _context.EventAttendances.Where(x => x.EventId == id).Include(x => x.Member).ToListAsync();
            return _mapper.Map<IList<Model.Response.EventAttendance>>(result);
        }

        public bool isAttending(int eventId,int memberId)
        {
            var entity = _context.EventAttendances.Where(x => x.EventId == eventId && x.MemberId == memberId).FirstOrDefault();
            if(entity!=null)
                return true;
            else
                return false;
        }

    }
}
