using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalCommittees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalCommittees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalCommittees_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
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
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalFieldId = table.Column<int>(type: "int", nullable: false),
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_FunctionalFields_FunctionalFieldId",
                        column: x => x.FunctionalFieldId,
                        principalTable: "FunctionalFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Member_LocalCommittees_LocalCommitteeId",
                        column: x => x.LocalCommitteeId,
                        principalTable: "LocalCommittees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Member_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_EventAttendances_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
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
                    MemberExecutorId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Tasks_Member_MemberCreatorId",
                        column: x => x.MemberCreatorId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Member_MemberExecutorId",
                        column: x => x.MemberExecutorId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "LocalCommitteeId", "Name", "Postcode" },
                values: new object[,]
                {
                    { 1, null, "Sarajevo", "71000" },
                    { 2, null, "Mostar", "88000" },
                    { 3, null, "Zenica", "72000" },
                    { 4, null, "Banja Luka", "78000" },
                    { 5, null, "Sarajevo", "71000" },
                    { 6, null, "Tuzla", "77000" }
                });

            migrationBuilder.InsertData(
                table: "FunctionalFields",
                columns: new[] { "Id", "Abbreviation", "Active", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "PD", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(2149), null, "Partnership Development" },
                    { 2, "MKT", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6559), null, "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6613), null, "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6624), null, "Outgoing Global Volounteere" },
                    { 5, "P", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6635), null, "Presidency" },
                    { 6, "TM", true, new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6646), null, "Talent Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "TeamMember" },
                    { 3, "Leader" }
                });

            migrationBuilder.InsertData(
                table: "LocalCommittees",
                columns: new[] { "Id", "Active", "CityId", "CreatedDate", "EstablishmentDate" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(3772), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(2785) },
                    { 2, true, 2, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4632), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4596) },
                    { 3, true, 3, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4658), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4654) },
                    { 4, true, 4, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4670), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4666) },
                    { 5, true, 5, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4682), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4678) },
                    { 6, true, 6, new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4694), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4690) }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "Address", "BirthDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hari.hodzic98@gmail.com", "Haris", 1, " ", "Hodzic", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "7uCzMk91WqCBdxHADlx3sg==", "062123344", 1, "harishodzic" },
                    { 2, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sulejman.tutnjevic98@gmail.com", "Sulejman", 1, " ", "Tutnjevic", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "qotijbhmLmOz88544dUHYA==", "062123344", 2, "sulejmantutnjevic" },
                    { 7, "Grbavica 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doraglinac@gmail.com", "Dora", 1, " ", "Glinac", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "42/+Rt13D2eNRN0XOfRRQw==", "062123344", 2, "doraglinac" },
                    { 8, "Borik 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikola.bujak@gmail.com", "Nikola", 2, " ", "Bujak", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "Sj8MSuE5Hn2ma5fBbrXpyQ==", "062123344", 2, "nikolabujak" },
                    { 9, "Gospodska 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nevzudindosic@gmail.com", "Nevzudin", 2, " ", "Dosic", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "Sj8MSuE5Hn2ma5fBbrXpyQ==", "062123344", 2, "nevzudindosic" },
                    { 10, "Mostar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "klarazovko@gmail.com", "Klara", 2, " ", "Zovko", 1, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "8+tvUWvHfukpPc4o7eLryA==", "062123344", 3, "klarazovko" },
                    { 3, "Zahira Panjete 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarik.bucan98@gmail.com", "Tarik", 1, " ", "Bucan", 2, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "tnuMgcPKaH/DEmyJAc+Vkg==", "062123344", 2, "tarikbucan" },
                    { 4, "Grbavica 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "selma.idic@aiesec.com", "Selma", 1, " ", "Idic", 2, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "6i/aHMwG8iBX+wU8zwuoyQ==", "062123344", 2, "selmaidic" },
                    { 5, "Dobrinjska 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ajdin.kahrimanovic8@aiesec.com", "Ajdin", 1, " ", "Kahrimanovic", 2, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "uCY3d1SXRoO/9bUR254zng==", "062123344", 3, "ajdinkahrimanovic" },
                    { 6, "Doglodi 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emir.zukic@gmail.com", "Emir", 1, " ", "Zukic", 2, "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "SjIuPg3wazh3jWIZqBcxpQ==", "062123344", 2, "emirzukic" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(1090), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(3475), 1 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4352), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4389), 2 },
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4410), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4415), 3 },
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4427), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4431), 4 }
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
                name: "IX_LocalCommittees_CityId",
                table: "LocalCommittees",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_FunctionalFieldId",
                table: "Member",
                column: "FunctionalFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_LocalCommitteeId",
                table: "Member",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_RoleId",
                table: "Member",
                column: "RoleId");

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
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "FunctionalFields");

            migrationBuilder.DropTable(
                name: "LocalCommittees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
