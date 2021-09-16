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
    public class TaskService:CRUDService<Model.Response.TaskDetails,Database.Task, Model.Search.Task, Model.Update.Task, Model.Insert.Task>, ITaskService
    {
        public TaskService(AiesecContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<TaskDetails> Execute(int id,int memberId)
        {
            var entity = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            if(entity==null)
                return null;
            if (entity.Executed == true)
            {
                entity.MemberExecutorId = null;
                entity.Executed = false;
            }
            else
            {
                entity.MemberExecutorId = memberId;
                entity.Executed = true;
                entity.DateOfExecution = DateTime.Now;
            }
            _context.Tasks.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.TaskDetails>(entity);
        }

        public override async Task<IEnumerable<TaskDetails>> Get([FromQuery] Model.Search.Task search = null)
        {
            var query = _context.Tasks.AsQueryable();
            if (search?.Executed == false)
            {
                query = query.Where(x => x.Executed == false);
            }
            if (search?.LocalCommitteeId != 0)
            {
                query = query.Where(x => x.LocalCommitteeId == search.LocalCommitteeId);
            }
            if (search?.FunctionalFieldId != 0)
            {
                query = query.Where(x => x.FunctionalFieldId == search.FunctionalFieldId);
            }
            if (search?.RoleId != 0)
            {
                query = query.Where(x => x.RoleId ==search.RoleId);
            }
            //var entities = await query.Include(x => x.).ThenInclude(x => x.FunctionalField)..ToListAsync();
            var entities = await query.Include(x => x.LocalCommittee).Include(x => x.Role).Include(x=>x.MemberExecutor).Include(x => x.FunctionalField).OrderByDescending(x=>x.Deadline).ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.TaskDetails>>(entities);
            return result;
        }
        public override Task<TaskDetails> Insert(Model.Insert.Task request)
        {
            var member = _context.Members.FirstOrDefault(x => x.Id == request.MemberCreatorId);
            request.FunctionalFieldId = member.FunctionalFieldId;
            request.RoleId = member.RoleId+1;//We want for task to be asigned to members with lower role, for example if President created task, it will be assigned for VicePresidents
            request.LocalCommitteeId = member.LocalCommitteeId;
            return base.Insert(request);
        }
    }
}
