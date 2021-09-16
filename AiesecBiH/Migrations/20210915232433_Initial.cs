using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.API.Migrations
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
                    { 1, "P", true, new DateTime(2021, 9, 16, 1, 24, 31, 957, DateTimeKind.Local).AddTicks(6604), null, "Presidency" },
                    { 2, "MKT", true, new DateTime(2021, 9, 16, 1, 24, 31, 957, DateTimeKind.Local).AddTicks(8902), null, "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 9, 16, 1, 24, 31, 957, DateTimeKind.Local).AddTicks(8946), null, "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 9, 16, 1, 24, 31, 957, DateTimeKind.Local).AddTicks(8963), null, "Outgoing Global Volounteere" },
                    { 5, "PD", true, new DateTime(2021, 9, 16, 1, 24, 31, 957, DateTimeKind.Local).AddTicks(8978), null, "Partnership Development" }
                });

            migrationBuilder.InsertData(
                table: "LocalCommittees",
                columns: new[] { "Id", "Active", "CreatedDate", "EstablishmentDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(900), new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(85), "<Undefined>" },
                    { 2, true, new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1932), new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1839), "Sarajevo" },
                    { 3, true, new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1966), new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1957), "Mostar" },
                    { 4, true, new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1991), new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(1983), "Zenica" },
                    { 5, true, new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(2016), new DateTime(2021, 9, 16, 1, 24, 31, 962, DateTimeKind.Local).AddTicks(2009), "Banja Luka" }
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
                columns: new[] { "Id", "Active", "AllFunctionalFields", "AllLocalCommittees", "AllMembers", "CreatedDate", "DateTime", "Description", "FunctionalFieldId", "IsOnline", "LocalCommitteeId", "Name" },
                values: new object[,]
                {
                    { 1, true, false, false, false, new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, false, 1, "Sastanak sa partnerima" },
                    { 2, true, false, false, false, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 7, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, false, 1, "Kontaktirati Dom armije" },
                    { 3, true, false, false, false, new DateTime(2020, 10, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 16, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 1, false, 1, "Odrzati intervju sa novim clanovima" },
                    { 5, true, false, false, false, new DateTime(2021, 5, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, false, 1, "Priprema za YSF" },
                    { 6, true, false, false, false, new DateTime(2021, 5, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, false, 1, "SWAT analiza za ITA" },
                    { 7, true, false, false, false, new DateTime(2021, 12, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, false, 1, "Kontaktirati govornike za YSF" },
                    { 8, true, false, false, false, new DateTime(2021, 12, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 2, false, 1, "Odabrati clanove za nesto" },
                    { 4, true, false, false, false, new DateTime(2020, 10, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", 3, false, 3, "Edukacija novih clanova" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CreatedDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 10, true, "Mostar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8576), "klarazovko@gmail.com", "Klara", 2, "F", "Zovko", 1, "OH010cT5i2GSw+2RyChpdG8krV217m0i9UgEDAt6nXYeYA5wmS+IOq77mu/swpbf6itUEOw1SoSii0BLKUcPlQ==", "zsN/AL97AwjT9YG2yUPTfg==", "062123344", 3, "klarazovko" },
                    { 7, true, "Grbavica 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8115), "doraglinac@gmail.com", "Dora", 1, "F", "Glinac", 2, "wP3xRoMom4xP/iusWawT7Jmnv3UBD0ED5b5sTvt4fZzNnMtZEnh9auPEp59pBanY27xiNZ9s7Y1JxAJEU2TCjA==", "21nCfoqzLD15xVWAfLauLQ==", "062123344", 3, "doraglinac" },
                    { 9, true, "Gospodska 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8476), "nevzudindosic@gmail.com", "Nevzudin", 2, "M", "Dosic", 2, "RgQ2bpgow5LZLJqQIngMP0NusQ1oIa+esVP3T0WOUZyVTOj506hbfbSjH8knisDYLQ8q6meWPptXMVFb20xx0Q==", "NWJlSr/99Lrcip9mLaGs7A==", "062123344", 2, "nevzudindosic" },
                    { 8, true, "Borik 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8222), "nikola.bujak@gmail.com", "Nikola", 2, "M", "Bujak", 2, "tjBCja+EPxy+LaNUjOM2J6FUTJV5r3J+ojon4oRmZML+eyFeo30YOgPp+3MOZXvt3ZsLeLQVYBFbM6E0vAoS/g==", "KhvPHEX8t1oP1EtvsxWEgw==", "062123344", 2, "nikolabujak" },
                    { 6, true, "Doglodi 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8015), "emir.zukic@gmail.com", "Emir", 5, "M", "Zukic", 3, "EFBNdvVPGOfK5ipFAcqp7+aCr+pg/uqNIs3hA4A2rzXZRdokF0GfE8OffUQly3EPZTeXx8gMcL1UUsjbUGGACg==", "VbYYIYKwV1lSyXIsYHxxOg==", "062123344", 2, "emirzukic" },
                    { 4, true, "Grbavica 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(7870), "selma.idic@aiesec.com", "Selma", 4, "M", "Idic", 1, "DTv1Z1DGKjLzdxGqhKtmTzcNc80usv/iemVI1I+DmlvQUZzsUvfp5UUBNzRM5mO82H2g4r+cbfq58QY/OnXL4g==", "4IreqT7fr9WKVF4X+o3QNA==", "062123344", 2, "selmaidic" },
                    { 3, true, "Zahira Panjete 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(7650), "tarik.bucan98@gmail.com", "Tarik", 3, "M", "Bucan", 2, "rsBg46sPHNPaxfE1N7QQJC413JOoxIvKFkm9A7bKRVZbEqBjUXnIwA9TkWNSjGXqNK88lcw1YJLhQXQzfYSm5w==", "RJWRhFFrYdkx6MTDjUzjow==", "062123344", 2, "tarikbucan" },
                    { 12, true, "Test 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8828), "harisbrulic@gmail.com", "Haris", 2, "M", "Brulic", 3, "OH010cT5i2GSw+2RyChpdG8krV217m0i9UgEDAt6nXYeYA5wmS+IOq77mu/swpbf6itUEOw1SoSii0BLKUcPlQ==", "zsN/AL97AwjT9YG2yUPTfg==", "062123344", 4, "harisbrulic" },
                    { 2, true, "Dobrinjska 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(5852), "hari.hodzic98@gmail.com", "Ajdin", 1, "M", "Kahrimanovic", 2, "nW/gPcJwmgsCPur2JEbRK3VVlOfB56OejQ0j7mDJ2fp52msvayqGxaRsdRcDahvtOXAP2T2bsvdL8vTldDWGlg==", "AwK9SDc396m9zgLh8pO8yw==", "062123344", 2, "ajdinkahrimanovic" },
                    { 1, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 971, DateTimeKind.Local).AddTicks(4051), "aiesec@tej.com", "Admin", 1, "M", "Admin", 1, "6tA0bZ6UhrFDaha3/Q6BE9cX2Tuz5LZjeJPFfEqV66Sz/SyMrwJYkVwB2txn8vwsMZ6yVP5XXkbeP2258I8k4A==", "7HivjxY/eZ5l388TaNiaQg==", "03355123", 1, "admin" },
                    { 11, true, "Centar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(8676), "hanakulenovic@gmail.com", "Hana", 1, "F", "Kulenovic", 4, "OH010cT5i2GSw+2RyChpdG8krV217m0i9UgEDAt6nXYeYA5wmS+IOq77mu/swpbf6itUEOw1SoSii0BLKUcPlQ==", "zsN/AL97AwjT9YG2yUPTfg==", "062123344", 4, "hanakulenovic" },
                    { 5, true, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 1, 24, 31, 982, DateTimeKind.Local).AddTicks(7201), "sulejman.tutnjevic98@gmail.com", "Sulejman", 2, "M", "Tutnjevic", 2, "a3COjvyV87ZFCXAFp65h5X3xdtG7ePUTVCo/9EMQsoJdgYFJX+2eQsdSlAFZpMY51LRkYp/jjzIN+92bf6jKNA==", "jIfPmZ5Za8aNsmjPuXxbTQ==", "062123344", 2, "sulejmantutnjevic" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5880), new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5888), 3 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5744), new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5837), 2 },
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(3083), new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5035), 1 },
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5910), new DateTime(2021, 9, 16, 1, 24, 31, 963, DateTimeKind.Local).AddTicks(5919), 4 }
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
                columns: new[] { "Id", "Active", "CreatedDate", "DateOfExecution", "Deadline", "Description", "Executed", "FunctionalFieldId", "LocalCommitteeId", "MemberCreatorId", "MemberExecutorId", "Name", "Priority", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2019, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Sastanak sa partnerima", 3, 3 },
                    { 2, true, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Kontaktirati Dom armije", 1, 3 },
                    { 3, true, new DateTime(2020, 10, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 1, 1, 2, null, "Odrzati intervju sa novim clanovima", 2, 3 },
                    { 7, true, new DateTime(2021, 12, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 6, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 1, 5, null, "Kontaktirati govornike za YSF", 1, 3 },
                    { 8, true, new DateTime(2021, 12, 10, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 2, 1, 5, null, "Odabrati clanove za nesto", 2, 3 },
                    { 4, true, new DateTime(2020, 10, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 3, 3, null, "Edukacija novih clanova", 2, 3 },
                    { 5, true, new DateTime(2021, 5, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 9, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 1, 3, null, "Priprema za YSF", 2, 3 },
                    { 6, true, new DateTime(2021, 5, 13, 12, 11, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 11, 12, 11, 0, 0, DateTimeKind.Unspecified), "Vestibulum semper lacus vel dolor consectetur, eu consequat lorem hendrerit.", false, 3, 1, 3, null, "SWAT analiza za ITA", 2, 3 }
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
