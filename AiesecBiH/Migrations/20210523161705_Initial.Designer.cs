﻿// <auto-generated />
using System;
using AiesecBiH.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AiesecBiH.Migrations
{
    [DbContext(typeof(AiesecContext))]
    [Migration("20210523161705_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AiesecBiH.Database.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sarajevo",
                            Postcode = "71000"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mostar",
                            Postcode = "88000"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Zenica",
                            Postcode = "72000"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Banja Luka",
                            Postcode = "78000"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sarajevo",
                            Postcode = "71000"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tuzla",
                            Postcode = "77000"
                        });
                });

            modelBuilder.Entity("AiesecBiH.Database.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("AllFunctionalFields")
                        .HasColumnType("bit");

                    b.Property<bool>("AllLocalCommittees")
                        .HasColumnType("bit");

                    b.Property<bool>("AllMembers")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FunctionalFieldId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<int?>("LocalCommitteeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FunctionalFieldId");

                    b.HasIndex("LocalCommitteeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AiesecBiH.Database.EventAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Attended")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("MemberId");

                    b.ToTable("EventAttendances");
                });

            modelBuilder.Entity("AiesecBiH.Database.FileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileModels");
                });

            modelBuilder.Entity("AiesecBiH.Database.FunctionalField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("FunctionalFields");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "PD",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 591, DateTimeKind.Local).AddTicks(3356),
                            Name = "Partnership Development"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "MKT",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 599, DateTimeKind.Local).AddTicks(358),
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "IGV",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 599, DateTimeKind.Local).AddTicks(513),
                            Name = "Incomming Global Volounteere"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "OGV",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 599, DateTimeKind.Local).AddTicks(530),
                            Name = "Outgoing Global Volounteere"
                        },
                        new
                        {
                            Id = 5,
                            Abbreviation = "P",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 599, DateTimeKind.Local).AddTicks(539),
                            Name = "Presidency"
                        },
                        new
                        {
                            Id = 6,
                            Abbreviation = "TM",
                            Active = true,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 599, DateTimeKind.Local).AddTicks(716),
                            Name = "Talent Management"
                        });
                });

            modelBuilder.Entity("AiesecBiH.Database.LocalCommittee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("LocalCommittees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CityId = 1,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(7309),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CityId = 2,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(8521),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CityId = 3,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(8607),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CityId = 4,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(8622),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CityId = 5,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(8633),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CityId = 6,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 603, DateTimeKind.Local).AddTicks(8642),
                            EstablishmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AiesecBiH.Database.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("AiesecBiH.Database.MemberAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("MemberAccount");
                });

            modelBuilder.Entity("AiesecBiH.Database.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocalCommitteeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("LocalCommitteeId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Address = "Trg Alije Izetbegovica 2",
                            Capacity = 20,
                            CityId = 1,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 604, DateTimeKind.Local).AddTicks(6020),
                            EstablishmentDate = new DateTime(2021, 5, 23, 18, 17, 3, 604, DateTimeKind.Local).AddTicks(9157)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Address = "Ulica 3",
                            Capacity = 10,
                            CityId = 2,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(348),
                            EstablishmentDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(437)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Address = "Ulica 4",
                            Capacity = 20,
                            CityId = 3,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(469),
                            EstablishmentDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(481)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Address = "Ulica 22",
                            Capacity = 20,
                            CityId = 4,
                            CreatedDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(489),
                            EstablishmentDate = new DateTime(2021, 5, 23, 18, 17, 3, 605, DateTimeKind.Local).AddTicks(497)
                        });
                });

            modelBuilder.Entity("AiesecBiH.Database.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileModelId")
                        .HasColumnType("int");

                    b.Property<string>("Mandate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quarter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileModelId")
                        .IsUnique();

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("AiesecBiH.Database.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TeamMember"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Leader"
                        });
                });

            modelBuilder.Entity("AiesecBiH.Database.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfExecution")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Executed")
                        .HasColumnType("bit");

                    b.Property<int>("FunctionalFieldId")
                        .HasColumnType("int");

                    b.Property<int>("LocalCommitteeId")
                        .HasColumnType("int");

                    b.Property<int>("MemberCreatorId")
                        .HasColumnType("int");

                    b.Property<int?>("MemberExecutorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FunctionalFieldId");

                    b.HasIndex("LocalCommitteeId");

                    b.HasIndex("MemberCreatorId");

                    b.HasIndex("MemberExecutorId");

                    b.HasIndex("RoleId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("AiesecBiH.Database.Event", b =>
                {
                    b.HasOne("AiesecBiH.Database.FunctionalField", "FunctionalField")
                        .WithMany("Events")
                        .HasForeignKey("FunctionalFieldId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("AiesecBiH.Database.LocalCommittee", "LocalCommittee")
                        .WithMany("Events")
                        .HasForeignKey("LocalCommitteeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("FunctionalField");

                    b.Navigation("LocalCommittee");
                });

            modelBuilder.Entity("AiesecBiH.Database.EventAttendance", b =>
                {
                    b.HasOne("AiesecBiH.Database.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("AiesecBiH.Database.LocalCommittee", b =>
                {
                    b.HasOne("AiesecBiH.Database.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("AiesecBiH.Database.Member", b =>
                {
                    b.HasOne("AiesecBiH.Database.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("AiesecBiH.Database.Office", b =>
                {
                    b.HasOne("AiesecBiH.Database.City", "City")
                        .WithMany("Offices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.LocalCommittee", "LocalCommittee")
                        .WithMany("Offices")
                        .HasForeignKey("LocalCommitteeId");

                    b.Navigation("City");

                    b.Navigation("LocalCommittee");
                });

            modelBuilder.Entity("AiesecBiH.Database.Report", b =>
                {
                    b.HasOne("AiesecBiH.Database.FileModel", "FileModel")
                        .WithOne("Report")
                        .HasForeignKey("AiesecBiH.Database.Report", "FileModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FileModel");
                });

            modelBuilder.Entity("AiesecBiH.Database.Task", b =>
                {
                    b.HasOne("AiesecBiH.Database.FunctionalField", "FunctionalField")
                        .WithMany()
                        .HasForeignKey("FunctionalFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.LocalCommittee", "LocalCommittee")
                        .WithMany()
                        .HasForeignKey("LocalCommitteeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.Member", "MemberCreator")
                        .WithMany("CreatedTasks")
                        .HasForeignKey("MemberCreatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.Member", "MemberExecutor")
                        .WithMany("ExecutedTasks")
                        .HasForeignKey("MemberExecutorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AiesecBiH.Database.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FunctionalField");

                    b.Navigation("LocalCommittee");

                    b.Navigation("MemberCreator");

                    b.Navigation("MemberExecutor");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AiesecBiH.Database.City", b =>
                {
                    b.Navigation("Offices");
                });

            modelBuilder.Entity("AiesecBiH.Database.FileModel", b =>
                {
                    b.Navigation("Report");
                });

            modelBuilder.Entity("AiesecBiH.Database.FunctionalField", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("AiesecBiH.Database.LocalCommittee", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Offices");
                });

            modelBuilder.Entity("AiesecBiH.Database.Member", b =>
                {
                    b.Navigation("CreatedTasks");

                    b.Navigation("ExecutedTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
