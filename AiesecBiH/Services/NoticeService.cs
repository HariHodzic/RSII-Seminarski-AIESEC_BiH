using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Services
{
    public class NoticeService: CRUDService<Model.Response.Notice, Database.Notice, Model.Search.Notice, Model.Update.Notice, Model.Insert.Notice>, INoticeService
    {
        public AiesecContext _context { get; set; }
        protected readonly IMapper _mapper;

        public NoticeService(AiesecContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<IEnumerable<Notice>> Get([FromQuery] Model.Search.Notice search = null)
        {
            var query =_context.Notices.Include(x => x.Member).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x =>x.Title.ToLower().StartsWith(search.Title.ToLower()));
            }
            if (search?.MemberId!=0)
            {
                query = query.Where(x => x.MemberId == search.MemberId);
            }
            var entities = await query.OrderByDescending(x=>x.CreatedDate).ToListAsync();
            return _mapper.Map<List<Model.Response.Notice>>(entities);
        }
        public override async Task<Notice> GetById(int id)
        {
            var result = await _context.Notices.Include(x=>x.Member).FirstOrDefaultAsync(x=>x.Id==id);
            //var result = await entity.FindAsync(id);
            if (result != null)
                return _mapper.Map<Model.Response.Notice>(result);
            else
                throw new NotFoundException("Object with this Id not found!");
        }
    }
}
