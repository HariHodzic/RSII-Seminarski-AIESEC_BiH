using AiesecBiH.EF;
using AiesecBiH.IServices;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Services
{
    public class NoticeService: CRUDService<Model.Response.Notice, Database.Notice, Model.Search.Notice, Model.Update.Notice, Model.Insert.Notice>, INoticeService
    {
        public NoticeService(AiesecContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
