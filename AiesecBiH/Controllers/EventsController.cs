using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;
using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AiesecBiH.Controllers
{
    public class EventsController : BaseCRUDController<Model.Response.Event,Model.Search.Event,Model.Update.Event,Model.Insert.Event>
    {
        private readonly IEventService _eventService;
        public EventsController(IEventService service):base(service)
        {
            _eventService = service;
        }

        [Authorize]
        [HttpPost("Attend/{id}")]
        public async Task<Model.Response.EventAttendance> Attend(int id, [FromBody] int memberId)
        {
            if (_eventService.isAttending(id, memberId))
                throw new Exception("Attendance already set!");
            var result = await _eventService.Attend(id, memberId);
            return result;
        }

        [Authorize]
        [HttpGet("GetAttendances/{id}")]
        public async Task<IEnumerable<Model.Response.EventAttendance>> GetAttendance(int id)
        {
            return await _eventService.GetAttendance(id);
        }

    }
}
