using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FunctionalFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalCommittees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalCommittees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quarter = table.Column<int>(type: "int", nullable: false),
                    Mandate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllFunctionalFields = table.Column<bool>(type: "bit", nullable: false),
                    AllLocalCommittees = table.Column<bool>(type: "bit", nullable: false),
                    AllMembers = table.Column<bool>(type: "bit", nullable: false),
                    FunctionalFieldId = table.Column<int>(type: "int", nullable: true),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_FunctionalFields_FunctionalFieldId",
                        column: x => x.FunctionalFieldId,
                        principalTable: "FunctionalFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_LocalCommittees_LocalCommitteeId",
                        column: x => x.LocalCommitteeId,
                        principalTable: "LocalCommittees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_LocalCommittees_LocalCommitteeId",
                        column: x => x.LocalCommitteeId,
                        principalTable: "LocalCommittees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FileModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileModels_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalFieldId = table.Column<int>(type: "int", nullable: true),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_FunctionalFields_FunctionalFieldId",
                        column: x => x.FunctionalFieldId,
                        principalTable: "FunctionalFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Members_LocalCommittees_LocalCommitteeId",
                        column: x => x.LocalCommitteeId,
                        principalTable: "LocalCommittees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Members_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Attended = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAttendances_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttendances_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notices_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Executed = table.Column<bool>(type: "bit", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfExecution = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberCreatorId = table.Column<int>(type: "int", nullable: false),
                    MemberExecutorId = table.Column<int>(type: "int", nullable: true),
                    FunctionalFieldId = table.Column<int>(type: "int", nullable: false),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_FunctionalFields_FunctionalFieldId",
                        column: x => x.FunctionalFieldId,
                        principalTable: "FunctionalFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_LocalCommittees_LocalCommitteeId",
                        column: x => x.LocalCommitteeId,
                        principalTable: "LocalCommittees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Members_MemberCreatorId",
                        column: x => x.MemberCreatorId,
                        principalTable: "Members",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Members_MemberExecutorId",
                        column: x => x.MemberExecutorId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FunctionalFields",
                columns: new[] { "Id", "Abbreviation", "Active", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "P", true, new DateTime(2021, 7, 22, 14, 41, 58, 168, DateTimeKind.Local).AddTicks(6806), null, "Presidency" },
                    { 2, "MKT", true, new DateTime(2021, 7, 22, 14, 41, 58, 168, DateTimeKind.Local).AddTicks(7745), null, "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 7, 22, 14, 41, 58, 168, DateTimeKind.Local).AddTicks(7775), null, "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 7, 22, 14, 41, 58, 168, DateTimeKind.Local).AddTicks(7784), null, "Outgoing Global Volounteere" },
                    { 5, "PD", true, new DateTime(2021, 7, 22, 14, 41, 58, 168, DateTimeKind.Local).AddTicks(7793), null, "Partnership Development" }
                });

            migrationBuilder.InsertData(
                table: "LocalCommittees",
                columns: new[] { "Id", "Active", "CreatedDate", "EstablishmentDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7411), new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(6451), "<Undefined>" },
                    { 2, true, new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7544), new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7520), "Sarajevo" },
                    { 3, true, new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7569), new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7561), "Mostar" },
                    { 4, true, new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7594), new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7586), "Zenica" },
                    { 5, true, new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7618), new DateTime(2021, 7, 22, 14, 41, 58, 171, DateTimeKind.Local).AddTicks(7610), "Banja Luka" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", "Administrator" },
                    { 2, "P", "President" },
                    { 3, "TL", "TeamLeader" },
                    { 4, "TM", "TeamMember" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CreatedDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 179, DateTimeKind.Local).AddTicks(7640), "aiesec@aiesec.com", "Admin", 1, "M", "Admin", 1, "PXbwgsNhPfVsDXUb57xb87N8kjCq8mQEg+gi2PQVwxvs2/aiEjq/RlZsZ55qnE26+rKasxM6nlFol7zwF64//A==", "bwtl5ZsjVTHZqg8v6/e69A==", "03355123", 1, "admin" },
                    { 2, true, "Dobrinjska 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 187, DateTimeKind.Local).AddTicks(7873), "ajdin.kahrimanovic8@aiesec.com", "Ajdin", 1, "M", "Kahrimanovic", 2, "Y8GrxVWP7tpna7E48Grl5/Sh149ph5g+Y7EjskSIQPU7WjlConV8c7S1eUMOFkR3j9QKM8zgkvznY+2PzxWXZw==", "pohLXxYB+B6GmzeViVs4XQ==", "062123344", 2, "ajdinkahrimanovic" },
                    { 5, true, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 187, DateTimeKind.Local).AddTicks(9821), "sulejman.tutnjevic98@gmail.com", "Sulejman", 2, "M", "Tutnjevic", 2, "y/uwppCK3TMBUWm5ZRKMFt6LvCzoDCvQX2VDe4CPuex2cwpUEDCQVmbobZxMchyqv12oIgeoHKYrDE+SqMdt/A==", "HvRX4kgbSTMIkpYxrJ4kqA==", "062123344", 2, "sulejmantutnjevic" },
                    { 3, true, "Zahira Panjete 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(62), "tarik.bucan98@gmail.com", "Tarik", 3, "M", "Bucan", 2, "c2jgm3RM/fH5yh1mmqCoGvsRyIfEW0KOZ+Y9tL++NQlHCB5o4ostTRPk62ED5AWqFD6PfX1b+sK9HkROUSQjgQ==", "emMNMMWc2ujfnbyOhZrvug==", "062123344", 2, "tarikbucan" },
                    { 4, true, "Grbavica 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(184), "selma.idic@aiesec.com", "Selma", 4, "M", "Idic", 1, "ioLQRxZK7gW7roHuiyiOqTCzQmFBZOCdShi26zjPaZqqsM4Z8xNmVhDGQqvsHkgMpqxd+HeLT06RLbq+HO73Kw==", "6XxGg+8NcRdfrH0MNfod3Q==", "062123344", 2, "selmaidic" },
                    { 6, true, "Doglodi 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(266), "emir.zukic@gmail.com", "Emir", 5, "M", "Zukic", 3, "h+stRd5L0TpJ8RcRjyAyZDhZsfOLGpqFMW5gfwrfiNg/Q7o/4jwQ0EBUIH8HQY9fxc14zyUz91kIDiFVSnckgw==", "f0ezYUTG0+bLJBD08cl+ww==", "062123344", 2, "emirzukic" },
                    { 8, true, "Borik 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(419), "nikola.bujak@gmail.com", "Nikola", 2, "M", "Bujak", 2, "z5QUERRy9Kjh0sgH96Y3Jys/UDVH74T/4rVgLA6Al6QiqowU0gUJ0lPgBZ8t0bOODQth78GDOPcKJ1a1+ISNog==", "xpwvY8wh7DEcy1FhmNleqg==", "062123344", 2, "nikolabujak" },
                    { 9, true, "Gospodska 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(492), "nevzudindosic@gmail.com", "Nevzudin", 2, "M", "Dosic", 2, "HtnXKeGoCq/2dmksQjXhp/pVtXfUrm50ZtoY7YsmKUtC7rLDf0qLKagr2tJ2KsMvRAiCzaptKztL7VrTRy4V/A==", "PbVwdlkActhd+tTmWK6upQ==", "062123344", 2, "nevzudindosic" },
                    { 7, true, "Grbavica 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(344), "doraglinac@gmail.com", "Dora", 1, "F", "Glinac", 2, "n78cjHrRJqCJmB/OmPdfii62y6E89VrXP9s/8diReJdfSHWsyiCfVbL8i9/sm8POW/VB4a4aAxz0XirG/bjXiQ==", "2Pah+3KVAsTbm/MrvXbxgw==", "062123344", 3, "doraglinac" },
                    { 10, true, "Mostar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(566), "klarazovko@gmail.com", "Klara", 2, "F", "Zovko", 1, "6DNaWTnXA75dGiDov7fcUMTFtNxC70t7IIpLNNpHHMjsm7VY6ro11olZ3q8cKmfMwSxx3533PvIZtvUXMbA6gg==", "MP9PncJbJChLklz5LCU71A==", "062123344", 3, "klarazovko" },
                    { 11, true, "Centar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(673), "hanakulenovic@gmail.com", "Hana", 1, "F", "Kulenovic", 4, "6DNaWTnXA75dGiDov7fcUMTFtNxC70t7IIpLNNpHHMjsm7VY6ro11olZ3q8cKmfMwSxx3533PvIZtvUXMbA6gg==", "MP9PncJbJChLklz5LCU71A==", "062123344", 4, "hanakulenovic" },
                    { 12, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 14, 41, 58, 188, DateTimeKind.Local).AddTicks(765), "harisbrulic@gmail.com", "Haris", 2, "M", "Brulic", 3, "6DNaWTnXA75dGiDov7fcUMTFtNxC70t7IIpLNNpHHMjsm7VY6ro11olZ3q8cKmfMwSxx3533PvIZtvUXMbA6gg==", "MP9PncJbJChLklz5LCU71A==", "062123344", 4, "harisbrulic" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(5231), new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(6928), 1 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7580), new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7656), 2 },
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7696), new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7705), 3 },
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7727), new DateTime(2021, 7, 22, 14, 41, 58, 172, DateTimeKind.Local).AddTicks(7736), 4 }
                });

            migrationBuilder.InsertData(
                table: "Notices",
                columns: new[] { "Id", "Body", "CreatedDate", "MemberId", "Title" },
                values: new object[,]
                {
                    { 1, "Otvaraju se prijave za poziciju MCP iduceg mandata.", new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 2, "Prijava za poziciju" },
                    { 4, "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", new DateTime(2020, 10, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), 5, "Fusce erat est fermentum" },
                    { 2, "Suspendisse convallis non orci sed viverra. Sed ac sapien vitae sapien cursus tincidunt quis id nibh. Quisque dictum et dolor in lobortis. Nulla turpis ligula, vehicula vel elit commodo, euismod fermentum lacus. Donec ligula turpis, maximus at velit a, fringilla lobortis ligula.", new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 3, "Fusce aliquam mi vehicula" },
                    { 3, "Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum,", new DateTime(2020, 8, 8, 12, 11, 0, 0, DateTimeKind.Unspecified), 4, "Nunc imperdiet urna ac orci" },
                    { 5, "Maecenas in tellus metus. Integer commodo turpis a massa tincidunt vulputate. Integer lacus ligula, tristique nec mi a, ultrices egestas lectus. Etiam rutrum et turpis nec auctor.", new DateTime(2021, 4, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 6, "Nunc quis quam pulvinar" },
                    { 6, "Nam augue augue, luctus vitae nisl at, finibus dictum orci. Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum.", new DateTime(2021, 5, 22, 12, 11, 0, 0, DateTimeKind.Unspecified), 7, "Aliquam vehicula enim" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Active", "CreatedDate", "DateOfExecution", "Deadline", "Description", "Executed", "FunctionalFieldId", "LocalCommitteeId", "MemberCreatorId", "MemberExecutorId", "Name", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Sastanak sa partnerima", 3 },
                    { 2, true, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Kontaktirati Dom armije", 3 },
                    { 3, true, new DateTime(2020, 10, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Odrzati intervju sa novim clanovima", 3 },
                    { 7, true, new DateTime(2021, 12, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 1, 5, null, "Kontaktirati govornike za YSF", 3 },
                    { 8, true, new DateTime(2021, 12, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 1, 5, null, "Odabrati clanove za nesto", 3 },
                    { 4, true, new DateTime(2020, 10, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 3, 3, null, "Edukacija novih clanova", 3 },
                    { 5, true, new DateTime(2021, 5, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 1, 3, null, "Priprema za YSF", 3 },
                    { 6, true, new DateTime(2021, 5, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 1, 3, null, "SWAT analiza za ITA", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_EventId",
                table: "EventAttendances",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_MemberId",
                table: "EventAttendances",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_FunctionalFieldId",
                table: "Events",
                column: "FunctionalFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocalCommitteeId",
                table: "Events",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_FileModels_ReportId",
                table: "FileModels",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_FunctionalFieldId",
                table: "Members",
                column: "FunctionalFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_LocalCommitteeId",
                table: "Members",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RoleId",
                table: "Members",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Notices_MemberId",
                table: "Notices",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_LocalCommitteeId",
                table: "Offices",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_FunctionalFieldId",
                table: "Tasks",
                column: "FunctionalFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LocalCommitteeId",
                table: "Tasks",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MemberCreatorId",
                table: "Tasks",
                column: "MemberCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MemberExecutorId",
                table: "Tasks",
                column: "MemberExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_RoleId",
                table: "Tasks",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAttendances");

            migrationBuilder.DropTable(
                name: "FileModels");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "FunctionalFields");

            migrationBuilder.DropTable(
                name: "LocalCommittees");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
