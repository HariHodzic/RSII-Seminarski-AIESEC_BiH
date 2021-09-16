using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.Model.Search;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace AiesecBiH.Services.BaseServices
{
    public class CRUDService<T,TDb, TSearch, TUpdate, TInsert> : ReadService<T,TDb,TSearch>, ICRUDService<T,TSearch,TUpdate,TInsert> 
        where T : class 
        where TSearch : class 
        where TInsert : class 
        where TUpdate : class 
        where TDb : class
    {
        public CRUDService(AiesecContext context, IMapper mapper) : base(context,mapper)
        {
        }

        public virtual async Task<T> Insert(TInsert request)
        {
            try
            {
                var set = _context.Set<TDb>();
                TDb entity = _mapper.Map<TDb>(request);
                set.Add(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<T>(entity);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            
        }

        public virtual async Task<T> Update(int id, TUpdate request)
        {
            var set = _context.Set<TDb>();
            TDb entity = set.Find(id);
            if (entity == null)
                throw new NotFoundException("Object with this ID doesn't exist");
            entity = _mapper.Map(request,entity);
            set.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }
        public virtual async Task<T> Delete(int id)
        {
            var entity = _context.Set<TDb>().Find(id);
            if (entity == null)
                throw new NotFoundException();
            _context.Set<TDb>().Remove(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<T>(entity);
        }
    } 
}
