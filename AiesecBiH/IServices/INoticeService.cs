using AiesecBiH.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.IServices
{
    public interface INoticeService: ICRUDService<Model.Response.Notice, Model.Search.Notice, Model.Update.Notice, Model.Insert.Notice>
    {
    }
}
