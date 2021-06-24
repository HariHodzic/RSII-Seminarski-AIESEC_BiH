using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Database;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office = AiesecBiH.Model.Response.Office;

namespace AiesecBiH.Services
{
    public class OfficeService:CRUDService<Model.Response.Office,Database.Office, Model.Search.Office, Model.Update.Office, Model.Insert.Office>,IOfficeService
    {
        public OfficeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
        public override async Task<IEnumerable<Model.Response.Office>> Get(Model.Search.Office? search)
        {
            var query = _context.Offices.AsQueryable();
            if (search.onlyActive == true)
            {
                query = query.Where(x => x.Active == true);
            }
            if (!string.IsNullOrWhiteSpace(search?.LocalCommitteeId.ToString()) && search?.LocalCommitteeId!=0)
            {
                query = query.Where(x => x.LocalCommitteeId == search.LocalCommitteeId);
            }
            var entities = await query.Include(x => x.LocalCommittee).ThenInclude(x => x.City).ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.Office>>(entities);
            return result;
        }

        public override async Task<Office> GetById(int id)
        {
            //Include(x => x.City)
            var result = await _context.Offices.Include(x => x.LocalCommittee).ThenInclude(x => x.City).FirstOrDefaultAsync(x=>x.Id==id);
            if (result != null)
                return _mapper.Map<Model.Response.Office>(result);
            else
                throw new NotFoundException("Object with this Id not found!");
        }
    }
}
