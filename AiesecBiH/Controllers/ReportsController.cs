using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.IServices;

namespace AiesecBiH.Controllers
{
    public class ReportsController : BaseCRUDController<Model.Response.Report, Model.Search.Report, object, Model.Insert.Report>
    {
        public ReportsController(IReportService service):base(service)
        {
        }
    }
}
