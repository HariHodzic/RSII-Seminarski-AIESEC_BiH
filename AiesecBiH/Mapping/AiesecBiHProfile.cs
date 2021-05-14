using AutoMapper;

namespace AiesecBiH.Mapping
{
    public class AiesecBiHProfile:Profile
    {
        public AiesecBiHProfile()
        {
            //FunctionalFields
            CreateMap<Model.Insert.FunctionalField, Database.FunctionalField>();
            CreateMap<Database.FunctionalField,Model.FunctionalField>();

            //Events
            CreateMap<Model.Insert.Event, Database.Event>();
            CreateMap<Database.Event, Model.Event>();

            //Office
            CreateMap<Model.Insert.Office, Database.Office>();
            CreateMap<Database.Office, Model.Office>();

            //Report
            CreateMap<Model.Insert.Report, Database.Report>();
            CreateMap<Database.Report, Model.Report>();

            //LocalCommittees
            CreateMap<Model.Insert.LocalCommittee, Database.LocalCommittee>();
            CreateMap<Database.LocalCommittee, Model.LocalCommittee>();

            //Task
            CreateMap<Model.Insert.Task, Database.Task>();
            CreateMap<Database.Task, Model.Task>();

            //City
            CreateMap<Model.Insert.City, Database.City>();
            CreateMap<Database.City, Model.City>();
        }
    }
}
