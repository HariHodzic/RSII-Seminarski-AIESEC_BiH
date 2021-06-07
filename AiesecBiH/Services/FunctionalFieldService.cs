using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AiesecBiH.Model;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AiesecBiH.Services
{
    public class FunctionalFieldService:CRUDService<Model.Response.FunctionalField,Database.FunctionalField,Model.Search.FunctionalField,Model.Update.FunctionalField,Model.Insert.FunctionalField>,IFunctionalFieldService
    {
        public FunctionalFieldService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }

        public override Model.Response.FunctionalField Insert(Model.Insert.FunctionalField request)
        {
            var entity = _mapper.Map<Database.FunctionalField>(request);
            _context.AddAsync(entity);
            _context.SaveChangesAsync();
            return _mapper.Map<FunctionalField>(entity);
        }

        public override async Task<IEnumerable<FunctionalField>> Get(Model.Search.FunctionalField search)
        {
            var query = _context.FunctionalFields.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name) );
            }
            if (!string.IsNullOrWhiteSpace(search?.Abbreviation))
            {
                query = query.Where(x => x.Abbreviation.StartsWith(search.Abbreviation));
            }
            if (search?.onlyActive != null && search.onlyActive == true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            var entities = await query.ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.FunctionalField>>(entities);
            return result;
        }
    }
}
