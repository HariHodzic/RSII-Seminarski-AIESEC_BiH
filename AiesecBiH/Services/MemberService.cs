using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Exceptions;
using AiesecBiH.IServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class MemberService:IMemberService
    {
        public AiesecContext _context { get; set; }
        protected readonly IMapper _mapper;
        private readonly ISecurityService _securityService;

        public MemberService(AiesecContext context, IMapper mapper,ISecurityService securityService)
        {
            _context = context;
            _mapper = mapper;
            _securityService = securityService;
        }
        public async Task<IEnumerable<Model.Response.MemberLL>> Get(Model.Search.Member search=null)
        {
            var query = _context.Member.Include(x=>x.LocalCommittee).ThenInclude(x=>x.City).Include(x=>x.FunctionalField).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x =>x.FirstName.ToLower().StartsWith(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().StartsWith(search.LastName.ToLower()));
            }
            if (search?.onlyActive != null && search.onlyActive == true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            if (!string.IsNullOrWhiteSpace(search?.FunctionalFieldId.ToString()) && search?.FunctionalFieldId != 0)
            {
                query = query.Where(x => x.FunctionalFieldId == search.FunctionalFieldId);
            }
            if (!string.IsNullOrWhiteSpace(search?.LocalCommitteeId.ToString()) && search?.LocalCommitteeId != 0)
            {
                query = query.Where(x => x.LocalCommitteeId == search.LocalCommitteeId);
            }
            //if (search?.IncludeList != null)
            //{
            //    foreach (string item in search?.IncludeList)
            //    {
            //        query.Include(item);
            //    }
            //}
            var entities =await query.Include(x=>x.Role).ToListAsync();
            var result = _mapper.Map<IList<Model.Response.MemberLL>>(entities);


            return result;
        }
        public async Task<Model.Response.MemberLL> GetById(int id)
        {
            var entity = await _context.Member.FindAsync(id);

            return _mapper.Map<Model.Response.MemberLL>(entity);
        }
        public async Task<Model.Response.Member> Insert(Model.Insert.Member request)
        {
            Database.Member entity = _mapper.Map<Database.Member>(request);
            await _context.AddAsync((object) entity);
            var username = request.FirstName + request.LastName;
            entity.Username = username;
            int i = 0;
            while (await _context.Member.FirstOrDefaultAsync(x => x.Username == entity.Username) != null)
            {
                entity.Username = username + (i++).ToString();
            }

            //if (request.Password != request.ConfirmPassword)
            //{
            //    throw new UserException("Password confirmation not correct!");
            //}
            
            entity.PasswordSalt = _securityService.GenerateSalt();
            entity.PasswordHash = _securityService.GenerateHash(entity.PasswordSalt, "test");
            entity.RoleId = request.RoleId;

            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.Member>(entity);

        }

        public async Task<Model.Response.Member> Update(int id, Model.Update.Member request)
        {
            var entity = await _context.Member.FindAsync(id);
            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.Member>(entity);
        }
        public async Task<Model.Response.MemberLL> Login(string username, string password)
        {
            var entity = await _context.Member.Include(x=>x.FunctionalField).Include("Role").Include(x=>x.LocalCommittee).ThenInclude(x=>x.City).FirstOrDefaultAsync(x => x.Username == username);

            if (entity == null)
            {
                throw new UserException("Wrong username or password");
            }

            var hash = _securityService.GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Wrong username or password");
            }

            return _mapper.Map<Model.Response.MemberLL>(entity);
        }

    }
}

