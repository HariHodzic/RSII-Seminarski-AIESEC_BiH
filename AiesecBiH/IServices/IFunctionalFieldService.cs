using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Model;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface IFunctionalFieldService:ICRUDService<Model.Response.FunctionalField, Model.Search.FunctionalField , Model.Update.FunctionalField, Model.Insert.FunctionalField>
    {

    }
}
