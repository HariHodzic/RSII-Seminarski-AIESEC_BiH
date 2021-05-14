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
    public class LocalCommitteeService: CRUDService<Model.LocalCommittee, Database.LocalCommittee, Model.Search.LocalCommittee, Model.Update.LocalCommittee, Model.Insert.LocalCommittee>, ILocalCommitteeService
    {
        public LocalCommitteeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
    }
}
