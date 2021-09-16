using AiesecBiH.Model.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.IServices
{
    public interface IMemberService
    {
        Task<IEnumerable<Model.Response.MemberLL>> Get(Model.Search.Member search);

        Task<Model.Response.MemberLL> GetById(int id);

        Task<Model.Response.Member> Insert(Model.Insert.Member member);

        Task<Model.Response.Member> Update(int id, Model.Update.Member member);

        Task<Model.Response.MemberLL> Login(string username, string password);
        Task<Model.Response.Member> Remove(int id);
        Task<Model.Response.MemberLL> MyProfile();
        bool IsUniqueEmailAddress(string emailAddress);
        Task<Model.Response.MemberLL> ChangePassword(int id, ChangePasswordModel model);


    }
}
