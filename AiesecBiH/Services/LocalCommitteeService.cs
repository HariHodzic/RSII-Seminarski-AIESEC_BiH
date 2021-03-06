using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class LocalCommitteeService: CRUDService<Model.Response.LocalCommittee, Database.LocalCommittee, Model.Search.LocalCommittee, Model.Update.LocalCommittee, Model.Insert.LocalCommittee>, ILocalCommitteeService
    {
        public LocalCommitteeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
        public override async  Task<IEnumerable<LocalCommittee>> Get(Model.Search.LocalCommittee search=null)
        {
            var query = _context.LocalCommittees.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name));
            }
            if (search?.onlyActive!=null && search.onlyActive==true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            query = query.Where(x => x.Id != 1);
            var entities = await query.ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.LocalCommittee>>(entities);
            return result;
        }

        public override async Task<LocalCommittee> GetById(int id)
        {
            var result =await _context.LocalCommittees.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<Model.Response.LocalCommittee>(result);
        }

        public override async Task<LocalCommittee> Delete(int id)
        {
            var result =await _context.LocalCommittees.Include(y=>y.Offices).FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                throw new NotFoundException();
            }
            
            _context.Remove(result);
            await CleanUpMembers(id);
            await _context.SaveChangesAsync();
            await CleanUpOffices();
            return _mapper.Map<Model.Response.LocalCommittee>(result);
            
        }

        public async System.Threading.Tasks.Task CleanUpOffices()
        {
            var offices = await _context.Offices.Where(x => x.LocalCommitteeId == null).ToListAsync();
            if (offices != null)
            {
                _context.Offices.RemoveRange(offices);
                await _context.SaveChangesAsync();
            }
        }
        public async System.Threading.Tasks.Task CleanUpMembers(int id)
        {
            var members = await _context.Members.Where(x => x.LocalCommitteeId == id).ToListAsync();
            foreach (Database.Member item in members)
            {
                item.LocalCommitteeId = 1;
                item.Active = false;
            }
            _context.Members.UpdateRange(members);
            await _context.SaveChangesAsync();
        }
    }
}
