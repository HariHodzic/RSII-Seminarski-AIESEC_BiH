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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.Services
{
    public class MemberService:IMemberService
    {
        public AiesecContext _context { get; set; }
        protected readonly IMapper _mapper;
        private readonly ISecurityService _securityService;
        private readonly IMailService _mailService;

        public MemberService(AiesecContext context, IMapper mapper,ISecurityService securityService, IMailService mailService)
        {
            _context = context;
            _mapper = mapper;
            _securityService = securityService;
            _mailService = mailService;
        }


        public async Task<IEnumerable<Model.Response.MemberLL>> Get(Model.Search.Member search=null)
        {
            var query = _context.Members.Include(x=>x.LocalCommittee).Include(x=>x.FunctionalField).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.Username==search.Username);
            }
            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x =>x.FirstName.ToLower().StartsWith(search.FirstName.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.EmailAddress==search.Email);

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
        public async Task<Model.Response.MemberLL> MyProfile()
        {
            var query = _context.Members.AsQueryable();

            query = query.Where(x => x.Id == Authentication.BasicAuthenticationHandler.LoggedMember.Id);

            query = query.Include(x => x.Role);
            query = query.Include(x => x.FunctionalField);
            query = query.Include(x => x.LocalCommittee);

            var entity =await query.FirstOrDefaultAsync();

            return _mapper.Map<Model.Response.MemberLL>(entity);
        }


        public async Task<Model.Response.MemberLL> GetById(int id)
        {
            var entity = await _context.Members.FindAsync(id);

            return _mapper.Map<Model.Response.MemberLL>(entity);
        }


        public async Task<Model.Response.Member> Insert(Model.Insert.Member request)
        {
            try
            {
                Database.Member entity = _mapper.Map<Database.Member>(request);
                await _context.AddAsync((object) entity);
                var username = request.FirstName + request.LastName;
                entity.Username = username;
                int i = 0;
                while (await _context.Members.FirstOrDefaultAsync(x => x.Username == entity.Username) != null)
                {
                    entity.Username = username + (i++).ToString();
                }
                var generatedPassword = _securityService.GeneratePassword();
                entity.PasswordSalt = _securityService.GenerateSalt();
                entity.PasswordHash = _securityService.GenerateHash(entity.PasswordSalt, generatedPassword);
                entity.RoleId = request.RoleId;
                await _mailService.SendRegistrationConfirmaiton(entity.Username, generatedPassword, entity.FirstName, entity.LastName, entity.EmailAddress);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Response.Member>(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Model.Response.Member> Update(int id, Model.Update.Member request)
        {
            try
            {
                var entity = await _context.Members.FindAsync(id);
                _mapper.Map(request, entity);
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Response.Member>(entity);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<Model.Response.MemberLL> Login(string username, string password)
        {
            var entity = await _context.Members.Include(x=>x.FunctionalField).Include("Role").Include(x=>x.LocalCommittee).FirstOrDefaultAsync(x => x.Username == username);

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


        public async Task<Model.Response.Member> Remove(int id)
        {
            var entity=await _context.Members.FindAsync(id);
            if (entity == null)
                throw new NotFoundException("Memeber not found");
            else
            {
                _context.Members.Remove(entity);
                await _context.SaveChangesAsync();
            }
            return _mapper.Map<Model.Response.Member>(entity);

        }

        public bool IsUniqueEmailAddress(string emailAddress)
        {
            var result = _context.Members.FirstOrDefault(x => x.EmailAddress == emailAddress);
            if (result != null)
                return false;
            return true;
        }

        public async Task<Model.Response.MemberLL> ChangePassword(int id, Model.Update.ChangePasswordModel model)
        {
            var member =await _context.Members.FirstOrDefaultAsync(x => x.Id == id);

            if (member == null)
            {
                throw new UserException("User not found!");
            }

            var oldHash = _securityService.GenerateHash(member.PasswordSalt, model.OldPassword);
            if (oldHash != member.PasswordHash)
            {
                throw new UserException("Wrong old password");
            }

            member.PasswordHash = _securityService.GenerateHash(member.PasswordSalt, model.NewPassword);
            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.MemberLL>(member);
        }
    }
}

