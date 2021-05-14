using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Model;
using AiesecBiH.Services.BaseServices;
using AutoMapper;

namespace AiesecBiH.Services
{
    public class FunctionalFieldService:CRUDService<Model.FunctionalField,Database.FunctionalField,object,Model.Update.FunctionalField,Model.Insert.FunctionalField>,IFunctionalFieldService
    {
        public FunctionalFieldService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }

        public override Model.FunctionalField Insert(Model.Insert.FunctionalField request)
        {
            var entity = _mapper.Map<Database.FunctionalField>(request);
            _context.AddAsync(entity);
            _context.SaveChangesAsync();
            return _mapper.Map<FunctionalField>(entity);
        }

        public override Task<FunctionalField> GetById(int id)
        {
            //if (_context.FunctionalFields.FindAsync(id) == null)
            //    return Exception();
            return base.GetById(id);    
        }
    }
}
