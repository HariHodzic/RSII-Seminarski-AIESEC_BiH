using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
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

        public virtual T Insert(TInsert request)
        {
            var set = _context.Set<TDb>();
            TDb entity = _mapper.Map<TDb>(request);
            set.AddAsync(entity);
            _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }

        //public virtual T Update(int id, TUpdate request)
        //{
        //    var set = _context.Set<TDb>();
        //    TDb entity = _mapper.Map<TDb>(request);
        //    set.Update(entity);
        //    _context.SaveChangesAsync();
        //    return _mapper.Map<T>(entity);
        //}
    }
}
