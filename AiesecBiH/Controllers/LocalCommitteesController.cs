using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;

namespace AiesecBiH.Controllers
{
    public class LocalCommitteesController : BaseCRUDController<Model.Response.LocalCommittee, Model.Search.LocalCommittee, Model.Update.LocalCommittee, Model.Insert.LocalCommittee>
    {
        public LocalCommitteesController(ILocalCommitteeService service):base(service)
        {
            
        }
    }
}
