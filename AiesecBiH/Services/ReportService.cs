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
    public class ReportService : CRUDService<Model.Response.Report, Database.Report, Model.Search.Report, object, Model.Insert.Report>,IReportService
    {
        public ReportService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            
        }
    }
}
