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
                    Name = "Presidency",
                    Abbreviation = "P",
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
                    Name = "Partnership Development",
                    Abbreviation = "PD",
                    Active = true,
                    CreatedDate = DateTime.Now,
                    Id = 5
                }
            );
        }
        public static void LocalCommitteeSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalCommittee>().HasData(
                new LocalCommittee
                {
                    Name = "<Undefined>",
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 1
                },
                new LocalCommittee
                {
                    Name = "Sarajevo",
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 2
                    //CityId = 1
                },
                new LocalCommittee
                {
                    Name = "Mostar",
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 3
                    //CityId = 2
                },
                new LocalCommittee
                {
                    Name = "Zenica",
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 4
                    //CityId = 3
                },
                new LocalCommittee
                {
                    Name = "Banja Luka",
                    Active = true,
                    EstablishmentDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Id = 5
                    //CityId = 4
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
                    FirstName = "Admin",
                    LastName = "Admin",
                    Username = "admin",
                    EmailAddress = "aiesec@tej.com",
                    PasswordSalt = salts[0],
                    PasswordHash = securityService.GenerateHash(salts[0], "test"),
                    LocalCommitteeId=1,
                    RoleId = 1,
                    FunctionalFieldId = 1,
                    PhoneNumber = "03355123",
                    Gender = 'M'
                },
                new Member
                {
                    Id = 2,
                    FirstName = "Ajdin",
                    LastName = "Kahrimanovic",
                    Username = "ajdinkahrimanovic",
                    Address = "Dobrinjska 12",
                    EmailAddress = "hari.hodzic98@gmail.com",
                    PhoneNumber = "062123344",
                    PasswordSalt = salts[4],
                    PasswordHash = securityService.GenerateHash(salts[4], "test"),
                    RoleId = 2,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    Gender = 'M'
                },
                new Member
                {
                    Id = 5,
                    FirstName = "Sulejman",
                    LastName = "Tutnjevic",
                    Username = "sulejmantutnjevic",
                    Address = "Safeta Zajke 298",
                    EmailAddress = "sulejman.tutnjevic98@gmail.com",
                    PasswordSalt = salts[1],
                    PasswordHash = securityService.GenerateHash(salts[1], "test"),
                    PhoneNumber = "062123344",
                    RoleId = 2,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 2,
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
                    PasswordSalt = salts[2],
                    PasswordHash = securityService.GenerateHash(salts[2], "test"),
                    PhoneNumber = "062123344",
                    RoleId = 2,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 3,
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
                    PasswordSalt = salts[3],
                    PasswordHash = securityService.GenerateHash(salts[3], "test"),
                    PhoneNumber = "062123344",
                    RoleId = 2,
                    LocalCommitteeId = 1,
                    FunctionalFieldId = 4,
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
                    PasswordSalt = salts[5],
                    PasswordHash = securityService.GenerateHash(salts[5], "test"),
                    PhoneNumber = "062123344",
                    RoleId = 2,
                    LocalCommitteeId = 3,
                    FunctionalFieldId = 5,
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
                    PasswordSalt = salts[6],
                    PasswordHash = securityService.GenerateHash(salts[6], "test"),
                    PhoneNumber = "062123344",
                    RoleId = 3,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 1,
                    Gender = 'F'
                },
                new Member
                {
                    Id = 8,
                    FirstName = "Nikola",
                    LastName = "Bujak",
                    Username = "nikolabujak",
                    Address = "Borik 4",
                    EmailAddress = "nikola.bujak@gmail.com",
                    PhoneNumber = "062123344",
                    PasswordSalt = salts[7],
                    PasswordHash = securityService.GenerateHash(salts[7], "test"),
                    RoleId = 2,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 2,
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
                    PasswordSalt = salts[8],
                    PasswordHash = securityService.GenerateHash(salts[8], "test"),
                    PhoneNumber = "062123344",
                    Gender = 'M',
                    RoleId = 2,
                    LocalCommitteeId = 2,
                    FunctionalFieldId = 2
                },
                new Member
                {
                    Id = 10,
                    FirstName = "Klara",
                    LastName = "Zovko",
                    Username = "klarazovko",
                    Address = "Mostar 4",
                    EmailAddress = "klarazovko@gmail.com",
                    PasswordSalt = salts[9],
                    PasswordHash = securityService.GenerateHash(salts[9], "test"),
                    PhoneNumber = "062123344",
                    Gender = 'F',
                    RoleId = 3,
                    FunctionalFieldId = 2,
                    LocalCommitteeId = 1
                },
                new Member
                {
                    Id = 11,
                    FirstName = "Hana",
                    LastName = "Kulenovic",
                    Username = "hanakulenovic",
                    Address = "Centar 4",
                    EmailAddress = "hanakulenovic@gmail.com",
                    PasswordSalt = salts[9],
                    PasswordHash = securityService.GenerateHash(salts[9], "test"),
                    PhoneNumber = "062123344",
                    Gender = 'F',
                    RoleId = 4,
                    FunctionalFieldId = 1,
                    LocalCommitteeId = 4
                },
                new Member
                {
                    Id = 12,
                    FirstName = "Haris",
                    LastName = "Brulic",
                    Username = "harisbrulic",
                    Address = "Test 4",
                    EmailAddress = "harisbrulic@gmail.com",
                    PasswordSalt = salts[9],
                    PasswordHash = securityService.GenerateHash(salts[9], "test"),
                    PhoneNumber = "062123344",
                    Gender = 'M',
                    RoleId = 4,
                    FunctionalFieldId = 2,
                    LocalCommitteeId = 3
                }
            );
        }

        public static void RoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Name = "Administrator", Id = 1, Abbreviation="Admin"},
                new Role { Name = "President", Id = 2, Abbreviation="P" },
                new Role {Name = "TeamLeader", Id = 3, Abbreviation="TL"},
                new Role {Name = "TeamMember", Id = 4, Abbreviation="TM"}
            );
        }

        public static void NoticeSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notice>().HasData(
                new Notice {Id=1, Title = "Prijava za poziciju", MemberId = 2, Body = "Otvaraju se prijave za poziciju MCP iduceg mandata.", CreatedDate = new DateTime(2019, 10, 12, 12, 11, 0) },
                new Notice {Id=2, Title = "Fusce aliquam mi vehicula", MemberId = 3, Body = "Suspendisse convallis non orci sed viverra. Sed ac sapien vitae sapien cursus tincidunt quis id nibh. Quisque dictum et dolor in lobortis. Nulla turpis ligula, vehicula vel elit commodo, euismod fermentum lacus. Donec ligula turpis, maximus at velit a, fringilla lobortis ligula.", CreatedDate= new DateTime(2019, 11, 12, 12, 11, 0) },
                new Notice {Id=3, Title = "Nunc imperdiet urna ac orci", MemberId = 4, Body = "Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum,", CreatedDate = new DateTime(2020, 8, 8, 12, 11, 0) },
                new Notice {Id=4, Title = "Fusce erat est fermentum", MemberId = 5, Body = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 10, 12, 11, 0) },
                new Notice {Id=5, Title = "Nunc quis quam pulvinar", MemberId = 6, Body = "Maecenas in tellus metus. Integer commodo turpis a massa tincidunt vulputate. Integer lacus ligula, tristique nec mi a, ultrices egestas lectus. Etiam rutrum et turpis nec auctor.", CreatedDate = new DateTime(2021,4,12,12,11,0) },
                new Notice {Id=6, Title = "Aliquam vehicula enim", MemberId = 7, Body = "Nam augue augue, luctus vitae nisl at, finibus dictum orci. Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum.", CreatedDate = new DateTime(2021, 5, 22, 12, 11, 0) }
            );
        }

        public static void TasksSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database.Task>().HasData(
                new Database.Task { Id = 1, Name = "Sastanak sa partnerima", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2019, 10, 12, 12, 11, 0), Deadline = new DateTime(2020, 11, 12, 12, 11, 0), MemberCreatorId = 2, Executed =false, RoleId=3,LocalCommitteeId=1, FunctionalFieldId=1,Priority=Model.Priority.High,},
                new Database.Task { Id = 2, Name = "Kontaktirati Dom armije", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 12, 12, 11, 0), Deadline = new DateTime(2020, 11, 11, 12, 11, 0), MemberCreatorId = 2, Executed =false, RoleId = 3, LocalCommitteeId = 1, FunctionalFieldId=1, Priority=Model.Priority.Low },
                new Database.Task { Id = 3, Name = "Odrzati intervju sa novim clanovima", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 13, 12, 11, 0), Deadline = new DateTime(2020, 10, 12, 12, 11, 0), MemberCreatorId = 2, Executed =false, RoleId = 3, LocalCommitteeId = 1, FunctionalFieldId = 1,Priority=Model.Priority.Medium },
                new Database.Task { Id = 4, Name = "Edukacija novih clanova", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 14, 12, 11, 0), Deadline = new DateTime(2020, 11, 12, 12, 11, 0), MemberCreatorId = 3, Executed=false, RoleId=3,LocalCommitteeId=3, FunctionalFieldId=3, Priority = Model.Priority.Medium },
                new Database.Task { Id = 5, Name = "Priprema za YSF", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 5, 14, 12, 11, 0), Deadline = new DateTime(2020, 11,9, 12, 11, 0), MemberCreatorId = 3, Executed=false, RoleId=3,LocalCommitteeId=1, FunctionalFieldId = 3, Priority = Model.Priority.Medium },
                new Database.Task { Id = 6, Name = "SWAT analiza za ITA", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 5, 13, 12, 11, 0), Deadline = new DateTime(2020, 7, 11, 12, 11, 0), MemberCreatorId = 3, Executed=false, RoleId=3,LocalCommitteeId=1, FunctionalFieldId=3, Priority = Model.Priority.Medium },
                new Database.Task { Id = 7, Name = "Kontaktirati govornike za YSF", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 12, 9, 12, 11, 0), Deadline = new DateTime(2020, 6, 12, 12, 11, 0), MemberCreatorId = 5, Executed=false, RoleId=3,LocalCommitteeId=1, FunctionalFieldId=2, Priority = Model.Priority.Low },
                new Database.Task { Id = 8, Name = "Odabrati clanove za nesto", Description= "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 12, 10, 12, 11, 0), Deadline = new DateTime(2020, 11, 12, 12, 11, 0), MemberCreatorId = 5, Executed=false, RoleId=3,LocalCommitteeId=1, FunctionalFieldId=2, Priority = Model.Priority.Medium }
            );
        }

        public static void EventsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database.Event>().HasData(
                new Database.Event { Id = 1, Name = "Sastanak sa partnerima", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2019, 10, 12, 12, 11, 0), DateTime = new DateTime(2020, 11, 12, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 1},
                new Database.Event { Id = 2, Name = "Kontaktirati Dom armije", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 12, 12, 11, 0), DateTime = new DateTime(2020, 7, 7, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 1 },
                new Database.Event { Id = 3, Name = "Odrzati intervju sa novim clanovima", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 13, 12, 11, 0), DateTime = new DateTime(2020, 12, 16, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 1 },
                new Database.Event { Id = 4, Name = "Edukacija novih clanova", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2020, 10, 14, 12, 11, 0), DateTime = new DateTime(2020, 10, 12, 12, 11, 0), LocalCommitteeId = 3, FunctionalFieldId = 3},
                new Database.Event { Id = 5, Name = "Priprema za YSF", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 5, 14, 12, 11, 0), DateTime = new DateTime(2019, 11, 12, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 3 },
                new Database.Event { Id = 6, Name = "SWAT analiza za ITA", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 5, 13, 12, 11, 0), DateTime = new DateTime(2019, 11, 12, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 3 },
                new Database.Event { Id = 7, Name = "Kontaktirati govornike za YSF", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 12, 9, 12, 11, 0), DateTime = new DateTime(2019, 11, 12, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 2 },
                new Database.Event { Id = 8, Name = "Odabrati clanove za nesto", Description = "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", CreatedDate = new DateTime(2021, 12, 10, 12, 11, 0), DateTime = new DateTime(2019, 11, 12, 12, 11, 0), LocalCommitteeId = 1, FunctionalFieldId = 2}
            );
        }
    }
}

