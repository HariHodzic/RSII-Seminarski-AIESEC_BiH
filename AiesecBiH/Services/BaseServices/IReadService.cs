using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AiesecBiH.Services.BaseServices
{
    public interface IReadService<T,TSearch> where T: class where TSearch:class
    {
        public Task<IEnumerable<T>> Get(TSearch search);
        public Task<T> GetById(int id);
    }
}
