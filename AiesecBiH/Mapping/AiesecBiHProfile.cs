using AutoMapper;

namespace AiesecBiH.Mapping
{
    public class AiesecBiHProfile:Profile
    {
        public AiesecBiHProfile()
        {
            //City
            CreateMap<Model.Insert.City, Database.City>();
            CreateMap<Model.Update.City, Database.City>();
            CreateMap<Database.City, Model.Response.City>();

            //Events
            CreateMap<Model.Insert.Event, Database.Event>();
            CreateMap<Database.Event, Model.Response.Event>();

            //EventAttendance
            CreateMap<Model.Insert.EventAttendance, Database.EventAttendance>();
            CreateMap<Database.EventAttendance, Model.Response.EventAttendance>();

            //FunctionalFields
            CreateMap<Model.Insert.FunctionalField, Database.FunctionalField>();
            CreateMap<Database.FunctionalField,Model.Response.FunctionalField>();
            CreateMap<Model.Update.FunctionalField,Database.FunctionalField>();
            //LocalCommittees
            CreateMap<Model.Insert.LocalCommittee, Database.LocalCommittee>();
            CreateMap<Model.Update.LocalCommittee, Database.LocalCommittee>();
            CreateMap<Database.LocalCommittee, Model.Response.LocalCommittee>();
            //Roles
            CreateMap<Database.Role, Model.Response.Role>();

            //Members
            CreateMap<Model.Insert.Member, Database.Member>();
            CreateMap<Model.Update.Member, Database.Member>();
            CreateMap<Database.Member, Model.Response.MemberLL>()
                .ForMember(x => x.RoleAbbreviation, opt => opt.MapFrom(x => x.Role.Abbreviation));
            CreateMap<Database.Member, Model.Response.Member>()
                .ForMember(x => x.RoleAbbreviation, opt => opt.MapFrom(x => x.Role.Abbreviation));
            //Office
            CreateMap<Model.Insert.Office, Database.Office>();
            CreateMap<Model.Update.Office, Database.Office>();
            CreateMap<Database.Office, Model.Response.Office>();
            //Report
            CreateMap<Model.Insert.Report, Database.Report>();
            CreateMap<Database.Report, Model.Response.Report>();
            //Task
            CreateMap<Model.Insert.Task, Database.Task>();
            CreateMap<Database.Task, Model.Response.TaskDetails>();
            CreateMap<Database.Task, Model.Response.Task>();
            //Notice
            CreateMap<Model.Insert.Notice, Database.Notice>();
            CreateMap<Database.Notice, Model.Response.Notice>()
                .ForMember(x => x.MemberUsername, opt => opt.MapFrom(y => y.Member.Username));
        }
    }
}
