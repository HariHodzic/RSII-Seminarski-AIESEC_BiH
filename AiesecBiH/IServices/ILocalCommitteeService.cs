using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Model;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface ILocalCommitteeService:ICRUDService<Model.Response.LocalCommittee, Model.Search.LocalCommittee, Model.Update.LocalCommittee, Model.Insert.LocalCommittee>
    {
    }
}
