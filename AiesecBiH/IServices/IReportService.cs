using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface IReportService : ICRUDService<Model.Response.Report, Model.Search.Report, Model.Update.Report, Model.Insert.Report>
    {

    }
}
