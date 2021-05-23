using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Database;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.EF
{
    public static class DataSeed
    {
        public static void FunctionalFieldsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FunctionalField>().HasData(
                new FunctionalField
                {
                    Name = "Partnership Development",
                    Abbreviation = "PD",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 1
                },
                new FunctionalField
                {
                    Name = "Marketing",
                    Abbreviation = "MKT",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 2
                },
                new FunctionalField
                {
                    Name = "Incomming Global Volounteere",
                    Abbreviation = "IGV",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 3
                },
                new FunctionalField
                {
                    Name = "Outgoing Global Volounteere",
                    Abbreviation = "OGV",
                    Active = true,
                    CreatedDate = DateTime.Now, Id = 4
                },
                new FunctionalField
                {
                    Name = "Presidency",
                    Abbreviation = "P",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 5
                },
                new FunctionalField
                {
                    Name = "Talent Management",
                    Abbreviation = "TM",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 6
                }
            );
        }

        public static void CitySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City {Id = 1, Name = "Sarajevo", Postcode = "71000"},
                new City {Id = 2, Name = "Mostar", Postcode = "88000"},
                new City {Id = 3, Name = "Zenica", Postcode = "72000"},
                new City {Id = 4, Name = "Banja Luka", Postcode = "78000"},
                new City {Id = 5, Name = "Sarajevo", Postcode = "71000"},
                new City {Id = 6, Name = "Tuzla", Postcode = "77000"}
            );

        }

        public static void LocalCommitteeSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalCommittee>().HasData(
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    CityId = 1
                },
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    CityId = 2
                },
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 3,
                    CityId = 3
                },
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 4,
                    CityId = 4
                },
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 5,
                    CityId = 5
                },
                new LocalCommittee
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 6,
                    CityId = 6
                }

            );
        }

        public static void OfficeSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>().HasData(
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    CityId = 1,
                    Capacity = 20,
                    Address = "Trg Alije Izetbegovica 2",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    CityId = 2,
                    Capacity = 10,
                    Address = "Ulica 3",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 3,
                    CityId = 3,
                    Capacity = 20,
                    Address = "Ulica 4",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 4,
                    CityId = 4,
                    Capacity = 20,
                    Address = "Ulica 22",
                    EstablishmentDate = DateTime.Now,
                }
            );
        }

        public static void RoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Name = "Admin", Id = 1},
                new Role {Name = "TeamMember", Id = 2},
                new Role {Name = "Leader", Id = 3}
            );
        }
    }
}

