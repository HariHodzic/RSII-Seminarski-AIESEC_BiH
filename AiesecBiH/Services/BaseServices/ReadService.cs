using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.Model.Search;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services.BaseServices
{
    public class ReadService<T, TDb, TSearch> : IReadService<T, TSearch> 
        where T:class 
        where TSearch:BaseSearchModel
        where TDb:class
    {
        protected readonly AiesecContext _context;
        protected readonly IMapper _mapper;

        public ReadService(AiesecContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public virtual async Task<IEnumerable<T>> Get([FromQuery] TSearch search=null )
        {
            var entity = _context.Set<TDb>();
            var list = await entity.ToListAsync();
            return _mapper.Map<List<T>>(list);
        }
         
        public virtual async Task<T> GetById(int id)
        {
            var entity = _context.Set<TDb>();
            var result = await entity.FindAsync(id);
            if (result != null)
                return _mapper.Map<T>(result);
            else
                throw new NotFoundException("Object with this Id not found!");
        }
    }
}
