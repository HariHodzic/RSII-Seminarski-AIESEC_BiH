using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class LocalCommitteeService: CRUDService<Model.Response.LocalCommittee, Database.LocalCommittee, Model.Search.LocalCommittee, Model.Update.LocalCommittee, Model.Insert.LocalCommittee>, ILocalCommitteeService
    {
        public LocalCommitteeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
        public override async Task<IEnumerable<LocalCommittee>> Get(Model.Search.LocalCommittee? search)
        {
            var query = _context.LocalCommittees.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.CityName))
            {
                query = query.Where(x => x.City.Name.StartsWith(search.CityName));
            }
            if (search?.onlyActive!=null && search.onlyActive==true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            //    Pretraziti lokalne komitete po imenu grada
            //    Provjeriti f metode dodatne koje se nadogradjuju na ovo

            var entities = await query.Include(x=>x.City).ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.LocalCommittee>>(entities);
            return result;
        }

        public override async Task<LocalCommittee> GetById(int id)
        {
            var result =await _context.LocalCommittees.Include(x => x.City).FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<Model.Response.LocalCommittee>(result);
        }
    }
}
