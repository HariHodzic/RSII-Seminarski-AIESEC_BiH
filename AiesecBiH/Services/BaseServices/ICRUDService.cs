using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Model.Search;

namespace AiesecBiH.Services.BaseServices
{
    public interface ICRUDService<T,TSearch,TUpdate,TInsert>:IReadService<T, TSearch>
        where T : class 
        where TSearch : BaseSearchModel
        where TInsert : class 
        where TUpdate : class
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
        T Delete(int id);
    }
}
