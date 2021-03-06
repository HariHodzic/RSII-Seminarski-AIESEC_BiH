using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial : Migration
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
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FunctionalFieldId = table.Column<int>(type: "int", nullable: false),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: true),
                    TimeUid = table.Column<long>(type: "bigint", nullable: false),
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
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    Priority = table.Column<int>(type: "int", nullable: false),
                    DateOfExecution = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { 1, "P", true, new DateTime(2021, 9, 25, 21, 45, 57, 70, DateTimeKind.Local).AddTicks(7462), "Functional field for members that lead the organization and local committees.", "Presidency" },
                    { 2, "MKT", true, new DateTime(2021, 9, 25, 21, 45, 57, 70, DateTimeKind.Local).AddTicks(9768), "Functional field that engages the target audience, build strong relationships to create value.", "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 9, 25, 21, 45, 57, 70, DateTimeKind.Local).AddTicks(9836), "iGV is the department that handles all that is related starting from attracting Exchange Participants (EPs) for our local projects.", "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 9, 25, 21, 45, 57, 70, DateTimeKind.Local).AddTicks(9852), "Outgoing Global Volunteer team is responsible for creating local strategies on converting opens to applicants.", "Outgoing Global Volounteere" },
                    { 5, "PD", true, new DateTime(2021, 9, 25, 21, 45, 57, 70, DateTimeKind.Local).AddTicks(9866), "Partnership Development is the department responsible for raising and maintaining the contact with our partners with activities ranging from cold calls.", "Partnership Development" }
                });

            migrationBuilder.InsertData(
                table: "LocalCommittees",
                columns: new[] { "Id", "Active", "CreatedDate", "EstablishmentDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2723), new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2116), "  " },
                    { 2, true, new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2823), new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2807), "Sarajevo" },
                    { 3, true, new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2836), new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2832), "Mostar" },
                    { 4, true, new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2849), new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(2845), "Zenica" }
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
                table: "Events",
                columns: new[] { "Id", "Active", "CreatedDate", "DateTime", "Description", "FunctionalFieldId", "LocalCommitteeId", "Name", "TimeUid" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2021, 2, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, 3, "BSA", 10L },
                    { 1, true, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, 2, "YSF 2020", 5L },
                    { 2, true, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, 2, "LCM", 3L },
                    { 3, true, new DateTime(2021, 8, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, 2, "Lorem", 2L },
                    { 4, true, new DateTime(2021, 10, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, 2, "Event 2", 5L },
                    { 5, true, new DateTime(2021, 11, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, 2, "Event 3", 2L },
                    { 6, true, new DateTime(2021, 5, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, 2, "Natco", 5L },
                    { 9, true, new DateTime(2021, 9, 15, 21, 45, 57, 100, DateTimeKind.Local).AddTicks(7365), new DateTime(2021, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, 2, "YSF event", 5L },
                    { 10, true, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, 2, "LCM", 4L },
                    { 8, true, new DateTime(2020, 12, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, 4, "Event", 7L }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CreatedDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 9, true, "Gospodska 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8617), "nevzudindosic@gmail.com", "Nevzudin", 3, "M", "Dosic", 2, "/i3mz/5voA7E4Y6H5iKAjANJLKNwP8dAPVrwlSsml1whVG1rOkQCEDL6Yy0Ev+IN/fPffMwifwbkSDAMbEC4kA==", "8ckzC0KTETAtbJTAEsJ/vA==", "062123344", 4, "nevzudindosic" },
                    { 11, true, "Centar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8817), "hanakulenovic@gmail.com", "Hana", 5, "F", "Kulenovic", 2, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "5AeikAcWnULuu2eazHq0mA==", "062123344", 4, "hanakulenovic" },
                    { 12, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8899), "test3@gmail.com", "Haris", 3, "M", "Brulic", 3, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "dx1TH+nwWs1hBVoYg/tjrw==", "062123344", 4, "harisbrulic" },
                    { 13, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8972), "ajdink@gmail.com", "Ajdin", 4, "M", "Kahrimanovic", 3, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "ugnW2rXmmz5h8J2RgD7etA==", "062123344", 4, "ajdink" },
                    { 3, true, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(7884), "sulejman.tutnjevic98@gmail.com", "Sulejman", 2, "M", "Tutnjevic", 2, "bd9/zzaC/T0B0V3JWKkVasacRt+hhUg8npcHhbchT+vATtZqPbtwVPRO95omKgYT/GehkehrMOPS4yYuj8hQPQ==", "NsKRPUtzH0q9vE/YJYv2ig==", "062123344", 3, "sulejmantutnjevic" },
                    { 15, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9110), "elmirbabovic@gmail.com", "Elmir", 4, "M", "Babovic", 3, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "D6o7rv+/6IsvmvBz5qlrgA==", "062123344", 4, "elmirbabovic" },
                    { 16, true, "Test 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9198), "irmasaric@gmail.com", "Irma", 2, "M", "Saric", 4, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "OhY/1Yt6VeargM0750rDPw==", "0621112222", 4, "irmasaric" },
                    { 7, true, "Grbavica 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8437), "doraglinac@gmail.com", "Dora", 3, "F", "Glinac", 2, "YA6U7lv9bWpmmmA6CPIDidRwtnSfi3HfLYx9moIExJ9c84jQvf6zJBBcEKGRngNrYgSw68tXSp8Mxn/JY9uMig==", "J2wb3Rdy4EkeAL9zEpdA7Q==", "062123344", 4, "doraglinac" },
                    { 17, true, "Dobrinja 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9266), "test2@gmail.com", "Ajla", 3, "M", "Brulic", 4, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "OhY/1Yt6VeargM0750rDPw==", "062123344", 4, "ajlabrulic" },
                    { 14, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9040), "denis@gmail.com", "Denis", 5, "M", "Music", 3, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "v458vszHzSpoTEJJmHwrJQ==", "062123344", 4, "denismusic" },
                    { 6, true, "Doglodi 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8350), "emir.zukic@gmail.com", "Emir", 2, "M", "Zukic", 2, "iUaE/HEBoBmvcSB4smPXAs2ZDrxMKOKGi6vbW4klAslZrvzlx66xRX9CRMNd2Tnl9aV6qhscgs351AVdaTrnSw==", "fikBh+/ZKF208t88/AheZg==", "062123344", 4, "emirzukic" },
                    { 19, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9399), "nejiravrana@gmail.com", "Nejira", 3, "Z", "Vrana", 4, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "OhY/1Yt6VeargM0750rDPw==", "062567948", 4, "nejiravrana" },
                    { 4, true, "Zahira Panjete 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8149), "tarik.bucan98@gmail.com", "Tarik", 2, "M", "Bucan", 2, "5zxPdrpi1qNh6KAwQuEWQPZGuRpzo6exlLbYXvXuo9wK6O6yP5f4UHgVqQnrS7xbCqtXtGH3aqtJriwVVo3tkQ==", "+zZMSNBXTltZPtu2yhfO0w==", "062123344", 4, "user1" },
                    { 10, true, "Mostar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8691), "klarazovko@gmail.com", "Klara", 4, "F", "Zovko", 2, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "5AeikAcWnULuu2eazHq0mA==", "062123344", 3, "klarazovko" },
                    { 8, true, "Borik 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8535), "nikola.bujak@gmail.com", "Nikola", 3, "M", "Bujak", 2, "ifcnGmOEunAF8MtJ/jgfRKpIedJ0U5r+EbzqtmGr4xSJk8D9C8/605YwYiwNXE3koQ/LRc/qjPkvTX1gaZPOhw==", "YsjfE5EAOITTM+t1fF3oVQ==", "062123344", 3, "nikolabujak" },
                    { 18, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(9332), "test1@gmail.com", "Haris", 4, "M", "Brulic", 4, "ePVpx3fKSyKCVSzlTH2tXUs9CzOWSY2LpNzplugzYWDCZzoQeIjpfzJaVwcObCkyJ+SwbmOuHA8gDAs1Xeuf6g==", "OhY/1Yt6VeargM0750rDPw==", "062123344", 4, "harisbrulic" },
                    { 2, true, "Dobrinjska 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(5543), "amel@gmail.com", "Amel", 1, "M", "Music", 2, "m2bDtswYeVkbwUM1UNji3DHqvmIUVEeLD3+XvgZuj5hBS95/fnuJAq1mi7qQJr5LUb8qh9KFXnqdfv/M3ZvHLg==", "XM7AIBCgnne+uODKXQt73g==", "062123344", 2, "user2" },
                    { 1, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 83, DateTimeKind.Local).AddTicks(757), "aiesec@tej.com", "Admin", 1, "M", "Admin", 1, "gtPBPEc8hXVnK7mJUSDTZrw4pPb+xIZrgl2uEylHr5+4nVQlqitUANuJo2eGIIGK6GsP76lww6oSL2hcD+gZLA==", "7HBe2/jcghPvbgCwi8GZkQ==", "03355123", 1, "admin" },
                    { 5, true, "Grbavica 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 21, 45, 57, 91, DateTimeKind.Local).AddTicks(8263), "selma.idic@aiesec.com", "Selma", 2, "M", "Idic", 2, "4o+vacvmO416UPGh4LSTz07Vn8ux45o23s5efryxG4K/uExSbEzyo5RML6WSBNRojk7/7fSnft9ELEN0Q7feZg==", "vxKy7hp+DPkWezbWMPKXcA==", "062123344", 4, "selmaidic" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(1007), new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(1011), 4 },
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(989), new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(994), 3 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(904), new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(964), 2 },
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 9, 25, 21, 45, 57, 74, DateTimeKind.Local).AddTicks(8787), new DateTime(2021, 9, 25, 21, 45, 57, 75, DateTimeKind.Local).AddTicks(433), 1 }
                });

            migrationBuilder.InsertData(
                table: "EventAttendances",
                columns: new[] { "Id", "Active", "Attended", "CreatedDate", "EventId", "MemberId" },
                values: new object[,]
                {
                    { 1, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(3734), 1, 2 },
                    { 15, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6505), 6, 11 },
                    { 13, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6492), 4, 5 },
                    { 8, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6456), 3, 5 },
                    { 4, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6426), 1, 5 },
                    { 10, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6471), 4, 4 },
                    { 9, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6464), 3, 4 },
                    { 18, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6526), 7, 11 },
                    { 3, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6413), 1, 4 },
                    { 17, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6519), 7, 10 },
                    { 14, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6499), 5, 10 },
                    { 7, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6448), 2, 4 },
                    { 16, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6512), 6, 12 },
                    { 12, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6485), 4, 2 },
                    { 6, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6440), 2, 3 },
                    { 11, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6478), 4, 3 },
                    { 2, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6290), 1, 3 },
                    { 5, true, false, new DateTime(2021, 9, 25, 21, 45, 57, 102, DateTimeKind.Local).AddTicks(6433), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Notices",
                columns: new[] { "Id", "Body", "CreatedDate", "MemberId", "Title" },
                values: new object[,]
                {
                    { 2, "Suspendisse convallis non orci sed viverra. Sed ac sapien vitae sapien cursus tincidunt quis id nibh. Quisque dictum et dolor in lobortis. Nulla turpis ligula, vehicula vel elit commodo, euismod fermentum lacus. Donec ligula turpis, maximus at velit a, fringilla lobortis ligula.", new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 3, "Fusce aliquam mi vehicula" },
                    { 6, "Nam augue augue, luctus vitae nisl at, finibus dictum orci. Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum.", new DateTime(2021, 5, 22, 12, 11, 0, 0, DateTimeKind.Unspecified), 7, "Aliquam vehicula enim" },
                    { 3, "Nunc in egestas dui. Fusce efficitur enim nunc, sit amet mattis dolor efficitur ac. Proin pulvinar urna non elit vestibulum,", new DateTime(2020, 8, 8, 12, 11, 0, 0, DateTimeKind.Unspecified), 4, "Nunc imperdiet urna ac orci" },
                    { 5, "Maecenas in tellus metus. Integer commodo turpis a massa tincidunt vulputate. Integer lacus ligula, tristique nec mi a, ultrices egestas lectus. Etiam rutrum et turpis nec auctor.", new DateTime(2021, 4, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 6, "Nunc quis quam pulvinar" },
                    { 1, "Otvaraju se prijave za poziciju MCP iduceg mandata.", new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 2, "Prijava za poziciju" },
                    { 4, "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", new DateTime(2020, 10, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), 5, "Fusce erat est fermentum" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Active", "CreatedDate", "DateOfExecution", "Deadline", "Description", "Executed", "FunctionalFieldId", "LocalCommitteeId", "MemberCreatorId", "MemberExecutorId", "Name", "Priority", "RoleId" },
                values: new object[,]
                {
                    { 10, true, new DateTime(2021, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 2, 3, 5, 7, "Kontaktirati sponzore za BSA", 2, 3 },
                    { 12, true, new DateTime(2021, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 4, 5, 7, "Kontaktirati sponzore za hranu, BSA", 2, 3 },
                    { 13, true, new DateTime(2021, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 3, 5, 6, "Kontaktirati Dom Armije za YSF", 2, 3 },
                    { 11, true, new DateTime(2021, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 4, 4, 5, 6, "Kupiti panel za BSA", 3, 3 },
                    { 9, true, new DateTime(2021, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 5, 6, "Sastanak sa Coca-Colom", 1, 3 },
                    { 8, true, new DateTime(2020, 1, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 5, 7, "Odlazak na aerodrom", 2, 3 },
                    { 1, true, new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 2, 2, "Sastanak sa partnerima", 3, 2 },
                    { 3, true, new DateTime(2020, 10, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 2, 3, "Odrzati intervju sa novim clanovima", 2, 3 },
                    { 16, true, new DateTime(2021, 9, 22, 21, 45, 57, 98, DateTimeKind.Local).AddTicks(3184), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 4, 3, "Kontaktirati stare clanove", 2, 3 },
                    { 15, true, new DateTime(2021, 9, 21, 21, 45, 57, 98, DateTimeKind.Local).AddTicks(3094), null, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 2, 2, 4, 3, "Uplatiti na racun", 2, 3 },
                    { 2, true, new DateTime(2020, 9, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 2, 2, "Kontaktirati Dom armije", 1, 3 },
                    { 14, true, new DateTime(2020, 9, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 1, 2, 2, 2, "Novi task", 1, 3 },
                    { 18, true, new DateTime(2021, 9, 23, 21, 45, 57, 98, DateTimeKind.Local).AddTicks(3221), null, new DateTime(2021, 7, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 2, 3, null, "Provjeriti cijene majica", 2, 3 },
                    { 17, true, new DateTime(2021, 9, 23, 21, 45, 57, 98, DateTimeKind.Local).AddTicks(3203), null, new DateTime(2021, 1, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 2, 3, null, "Priprema banera", 2, 3 },
                    { 6, true, new DateTime(2021, 5, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 2, 3, null, "SWAT analiza za ITA", 2, 3 },
                    { 5, true, new DateTime(2021, 1, 1, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 2, 2, 3, 1, "Priprema za YSF", 2, 3 },
                    { 7, true, new DateTime(2021, 12, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 2, 5, null, "Kontaktirati govornike za YSF", 1, 3 },
                    { 4, true, new DateTime(2020, 10, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", true, 2, 2, 3, 3, "Edukacija novih clanova", 2, 3 }
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
                name: "IX_Members_EmailAddress",
                table: "Members",
                column: "EmailAddress",
                unique: true,
                filter: "[EmailAddress] IS NOT NULL");

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
