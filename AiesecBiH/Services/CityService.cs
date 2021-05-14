using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;

namespace AiesecBiH.Services
{
    public class CityService: CRUDService<Model.City, Database.City, Model.Search.City, Model.Update.City, Model.Insert.City>, ICityService
    {
        public CityService(AiesecContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
