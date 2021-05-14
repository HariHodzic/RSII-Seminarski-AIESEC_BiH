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
    public class OfficeService:CRUDService<Model.Office,Database.Office, Model.Search.Office, Model.Update.Office, Model.Insert.Office>,IOfficeService
    {
        public OfficeService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
    }
}
