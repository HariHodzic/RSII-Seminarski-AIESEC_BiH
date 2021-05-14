using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Model;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface IFunctionalFieldService:ICRUDService<FunctionalField,object , Model.Update.FunctionalField, Model.Insert.FunctionalField>
    {

    }
}
