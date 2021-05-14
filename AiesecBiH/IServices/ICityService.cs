using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface ICityService: ICRUDService<Model.City, Model.Search.City, Model.Update.City, Model.Insert.City>
    {
    }
}
