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
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModels", x => x.Id);
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
                name: "MemberAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAccount", x => x.Id);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    FileModelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_FileModels_FileModelId",
                        column: x => x.FileModelId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Postcode" },
                values: new object[,]
                {
                    { 1, "Sarajevo", "71000" },
                    { 2, "Mostar", "88000" },
                    { 3, "Zenica", "72000" },
                    { 4, "Banja Luka", "78000" },
                    { 5, "Sarajevo", "71000" },
                    { 6, "Tuzla", "77000" }
                });

            migrationBuilder.InsertData(
                table: "FunctionalFields",
                columns: new[] { "Id", "Abbreviation", "Active", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "PD", true, new DateTime(2021, 6, 1, 15, 46, 27, 390, DateTimeKind.Local).AddTicks(7318), null, "Partnership Development" },
                    { 2, "MKT", true, new DateTime(2021, 6, 1, 15, 46, 27, 394, DateTimeKind.Local).AddTicks(8548), null, "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 6, 1, 15, 46, 27, 394, DateTimeKind.Local).AddTicks(8658), null, "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 6, 1, 15, 46, 27, 394, DateTimeKind.Local).AddTicks(8670), null, "Outgoing Global Volounteere" },
                    { 5, "P", true, new DateTime(2021, 6, 1, 15, 46, 27, 394, DateTimeKind.Local).AddTicks(8678), null, "Presidency" },
                    { 6, "TM", true, new DateTime(2021, 6, 1, 15, 46, 27, 394, DateTimeKind.Local).AddTicks(8684), null, "Talent Management" }
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
                    { 1, true, 1, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(4279), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(3326) },
                    { 2, true, 2, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5090), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5046) },
                    { 3, true, 3, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5110), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5105) },
                    { 4, true, 4, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5118), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5114) },
                    { 5, true, 5, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5126), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5122) },
                    { 6, true, 6, new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5134), new DateTime(2021, 6, 1, 15, 46, 27, 399, DateTimeKind.Local).AddTicks(5130) }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(159), new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(2351), 1 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3125), new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3181), 2 },
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3193), new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3199), 3 },
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3204), new DateTime(2021, 6, 1, 15, 46, 27, 400, DateTimeKind.Local).AddTicks(3208), 4 }
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
                name: "IX_LocalCommittees_CityId",
                table: "LocalCommittees",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_CityId",
                table: "Member",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_LocalCommitteeId",
                table: "Offices",
                column: "LocalCommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_FileModelId",
                table: "Reports",
                column: "FileModelId",
                unique: true);

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
                name: "MemberAccount");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FileModels");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "FunctionalFields");

            migrationBuilder.DropTable(
                name: "LocalCommittees");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
