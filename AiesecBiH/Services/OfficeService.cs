using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Database;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class OfficeService:CRUDService<Model.Response.Office,Database.Office, Model.Search.Office, Model.Update.Office, Model.Insert.Office>,IOfficeService
    {
        public OfficeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
        public override async Task<IEnumerable<Model.Response.Office>> Get(Model.Search.Office search)
        {
            var query = _context.Offices.AsQueryable();
            if (search.onlyActive == true)
            {
                query = query.Where(x => x.Active == true);
            }
            if (!string.IsNullOrWhiteSpace(search?.Address))
            {
                query = query.Where(x => x.Address == search.Address);
            }
            if (!string.IsNullOrWhiteSpace(search?.CityName))
            {
                query = query.Where(x => x.City.Name == search.CityName);
            }
            var entities = await query.ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.Office>>(entities);
            return result;
        }
    }
}
