using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AiesecBiH.Database;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using City = AiesecBiH.Model.Response.City;

namespace AiesecBiH.Services
{
    public class CityService: CRUDService<Model.Response.City, Database.City, Model.Search.City, Model.Update.City, Model.Insert.City>, ICityService
    {
        public CityService(AiesecContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<City> GetById(int id)
        {
            var entity = _context.Cities.FindAsync(id);
            if (entity == null)
                throw new NotFoundException();
            var result = await _context.Cities.Include(x => x.Offices.Where(x => x.CityId == id)).FirstOrDefaultAsync(x=>x.Id==id);
            var model =_mapper.Map<Model.Response.City>(result);
            return model;
        }
        public override Model.Response.City Update(int id, Model.Update.City request)
        {
            var entity = _context.Cities.Find(id);
            if (entity == null)
                throw new NotFoundException("Object with this ID doesn't exist");
            entity = _mapper.Map(request, entity);
            _context.Cities.Update(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Response.City>(entity);
        }
    }
}
