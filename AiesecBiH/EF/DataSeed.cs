using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AiesecBiH.Database;
using AiesecBiH.Services;
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
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    CityId = 1
                },
                new LocalCommittee
                {
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    CityId = 2
                },
                new LocalCommittee
                {
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 3,
                    CityId = 3
                },
                new LocalCommittee
                {
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 4,
                    CityId = 4
                },
                new LocalCommittee
                {
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 5,
                    CityId = 5
                },
                new LocalCommittee
                {
                    Active = true,
                    EstablishmentDate = DateTime.Now,
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
                    LocalCommitteeId = 1,
                    Capacity = 20,
                    Address = "Trg Alije Izetbegovica 2",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    LocalCommitteeId = 2,
                    Capacity = 10,
                    Address = "Ulica 3",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 3,
                    LocalCommitteeId = 3,
                    Capacity = 20,
                    Address = "Ulica 4",
                    EstablishmentDate = DateTime.Now,
                },
                new Office
                {
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 4,
                    LocalCommitteeId = 4,
                    Capacity = 20,
                    Address = "Ulica 22",
                    EstablishmentDate = DateTime.Now,
                }
            );
        }
        
    public static void MembersSeed(this ModelBuilder modelBuilder)
        {
            var securityService = new SecurityService();
            var salts = new List<string>();
            for (int i = 0; i < 16; i++)
            {
                salts.Add(securityService.GenerateSalt());
            }

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FirstName = "Haris",
                    LastName = "Hodzic",
                    Username = "harishodzic",
                    Address = "Safeta Zajke 298",
                    EmailAddress = "hari.hodzic98@gmail.com",
                    RoleId = 1,
                    PasswordSalt = salts[0],
                    PasswordHash = securityService.GenerateHash(salts[0], "test"),
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 2,
                    FirstName = "Sulejman",
                    LastName = "Tutnjevic",
                    Username = "sulejmantutnjevic",
                    Address = "Safeta Zajke 298",
                    EmailAddress = "sulejman.tutnjevic98@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[1],
                    PasswordHash = securityService.GenerateHash(salts[1], "test"),
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 3,
                    FirstName = "Tarik",
                    LastName = "Bucan",
                    Username = "tarikbucan",
                    Address = "Zahira Panjete 298",
                    EmailAddress = "tarik.bucan98@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[2],
                    PasswordHash = securityService.GenerateHash(salts[2], "test"),
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 4,
                    FirstName = "Selma",
                    LastName = "Idic",
                    Username = "selmaidic",
                    Address = "Grbavica 12",
                    EmailAddress = "selma.idic@aiesec.com",
                    RoleId = 2,
                    PasswordSalt = salts[3],
                    PasswordHash = securityService.GenerateHash(salts[3], "test"),
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 5,
                    FirstName = "Ajdin",
                    LastName = "Kahrimanovic",
                    Username = "ajdinkahrimanovic",
                    Address = "Dobrinjska 12",
                    EmailAddress = "ajdin.kahrimanovic8@aiesec.com",
                    RoleId = 3,
                    PasswordSalt = salts[4],
                    PasswordHash = securityService.GenerateHash(salts[4], "test"),
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 6,
                    FirstName = "Emir",
                    LastName = "Zukic",
                    Username = "emirzukic",
                    Address = "Doglodi 12",
                    EmailAddress = "emir.zukic@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[5],
                    PasswordHash = securityService.GenerateHash(salts[5], "test"),
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 7,
                    FirstName = "Dora",
                    LastName = "Glinac",
                    Username = "doraglinac",
                    Address = "Grbavica 4",
                    EmailAddress = "doraglinac@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[6],
                    PasswordHash = securityService.GenerateHash(salts[6], "test"),
                    LocalCommitteeId = 1,
                    Gender = 'F',
                    FunctionalFieldId = 1,
                    PhoneNumber = "062123344"
                },
                new Member
                {
                    Id = 8,
                    FirstName = "Nikola",
                    LastName = "Bujak",
                    Username = "nikolabujak",
                    Address = "Borik 4",
                    EmailAddress = "nikola.bujak@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[7],
                    PasswordHash = securityService.GenerateHash(salts[7], "test"),
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 2,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 9,
                    FirstName = "Nevzudin",
                    LastName = "Dosic",
                    Username = "nevzudindosic",
                    Address = "Gospodska 4",
                    EmailAddress = "nevzudindosic@gmail.com",
                    RoleId = 2,
                    PasswordSalt = salts[8],
                    PasswordHash = securityService.GenerateHash(salts[8], "test"),
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 2,
                    PhoneNumber = "062123344",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 10,
                    FirstName = "Klara",
                    LastName = "Zovko",
                    Username = "klarazovko",
                    Address = "Mostar 4",
                    EmailAddress = "klarazovko@gmail.com",
                    RoleId = 3,
                    PasswordSalt = salts[9],
                    PasswordHash = securityService.GenerateHash(salts[9], "test"),
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 2,
                    PhoneNumber = "062123344",
                    Gender = 'F'
                }
            );
        }

        public static void RoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Name = "Administrator", Id = 1, Abbreviation="Admin"},
                new Role {Name = "TeamMember", Id = 2, Abbreviation="TM"},
                new Role {Name = "TeamLeader", Id = 3, Abbreviation="TL"},
                new Role { Name = "President", Id = 4, Abbreviation="P" }
            );
        }
    }
}

