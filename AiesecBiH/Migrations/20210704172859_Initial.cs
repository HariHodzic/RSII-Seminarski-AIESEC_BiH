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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LocalCommitteeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_EventAttendances_Members_MemberId",
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
                        name: "FK_Tasks_Members_MemberCreatorId",
                        column: x => x.MemberCreatorId,
                        principalTable: "Members",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Members_MemberExecutorId",
                        column: x => x.MemberExecutorId,
                        principalTable: "Members",
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
                    { 1, "P", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(6678), null, "Presidency" },
                    { 2, "MKT", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(7520), null, "Marketing" },
                    { 3, "IGV", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(7545), null, "Incomming Global Volounteere" },
                    { 4, "OGV", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(7553), null, "Outgoing Global Volounteere" },
                    { 5, "PD", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(7561), null, "Partnership Development" },
                    { 6, "TM", true, new DateTime(2021, 7, 4, 19, 28, 58, 319, DateTimeKind.Local).AddTicks(7569), null, "Talent Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", "Administrator" },
                    { 2, "TM", "TeamMember" },
                    { 3, "TL", "TeamLeader" },
                    { 4, "P", "President" }
                });

            migrationBuilder.InsertData(
                table: "LocalCommittees",
                columns: new[] { "Id", "Active", "CityId", "CreatedDate", "EstablishmentDate" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(12), new DateTime(2021, 7, 4, 19, 28, 58, 321, DateTimeKind.Local).AddTicks(9550) },
                    { 2, true, 2, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(428), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(402) },
                    { 3, true, 3, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(448), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(444) },
                    { 4, true, 4, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(460), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(456) },
                    { 5, true, 5, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(471), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(468) },
                    { 6, true, 6, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(483), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(479) }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CreatedDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { 1, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 335, DateTimeKind.Local).AddTicks(4219), "aiesec@aiesec.com", "Admin", 1, "M", "Admin", null, "jvwBhCXoKuQHXTBP60JtFw4KujstWKSgt+iN8G9QDZNmOpK0fgt0Lr7KF44ZeRKiQDDrAeIs7G4amPoLN5LGkA==", "E/pTpOaYeFO8p7SzWvVdlA==", "03355123", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CreatedDate", "EmailAddress", "FirstName", "FunctionalFieldId", "Gender", "LastName", "LocalCommitteeId", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 2, true, "Safeta Zajke 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 345, DateTimeKind.Local).AddTicks(7025), "sulejman.tutnjevic98@gmail.com", "Sulejman", 1, "M", "Tutnjevic", 1, "8Bd742uYmjmCeUuIAV1DXAio4E6dSHHaljVHwhcRmk7k/Xb/PcACpctpZUf6j+h1xxzb7RWZyQcmHIGQiwwzXA==", "s/PwKiNaPI6gzjt7qA7YLQ==", "062123344", 2, "sulejmantutnjevic" },
                    { 7, true, "Grbavica 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(1906), "doraglinac@gmail.com", "Dora", 1, "F", "Glinac", 1, "9E+nAqANb2X2a3VN2Bf5J92BAN3jAKRCssLXCdL6aMtJOnpSYRmb0avT5RG5mXH3tE4hy5j7SVMA03+6u8d5nQ==", "KlYXk8I+4aMOsYAfDFDlaQ==", "062123344", 2, "doraglinac" },
                    { 8, true, "Borik 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(2304), "nikola.bujak@gmail.com", "Nikola", 2, "M", "Bujak", 1, "ATbjBbX37dnG84o0S9f9PMony3Av/dGsKV1YzWgxm6B5qag/JoIWCmjhuLaND2ZTZFvdSK2zofeniEtQk8c6Dw==", "UxUXaqU90poV2XRZ1+Ai0A==", "062123344", 2, "nikolabujak" },
                    { 9, true, "Gospodska 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(2485), "nevzudindosic@gmail.com", "Nevzudin", 2, "M", "Dosic", 1, "1CYXNs/u9qGEQOoOKC7e377hSLCKlzjMFbeztgKKdK4CMdARNVpn6PPujdY9es+Mqzu8GqG9Im3XzUxhht3QVg==", "mDfW4DFLJnkh7FZXRX4Veg==", "062123344", 2, "nevzudindosic" },
                    { 10, true, "Mostar 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(2573), "klarazovko@gmail.com", "Klara", 2, "F", "Zovko", 1, "4pz9KYwXccqaWNBnVsDYr28GquecAheWLryxFgYPicuEmFFplMuP8Aw/C5dcSbZltH5NxFe96qH3iMXSFVLfyw==", "8T3zkne7q/Igr2tSSFa8sg==", "062123344", 3, "klarazovko" },
                    { 3, true, "Zahira Panjete 298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(1226), "tarik.bucan98@gmail.com", "Tarik", 1, "M", "Bucan", 2, "ieaQ6bxONyVgoBy79F5D/QuWhu108R4rlZDjhDTploTxiksHlhn4jWWet9tctHFbOieRY9JnM+7m3/qm2MNtpg==", "nv/aJp/k23tOZLVbBorWtA==", "062123344", 2, "tarikbucan" },
                    { 4, true, "Grbavica 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(1583), "selma.idic@aiesec.com", "Selma", 1, "M", "Idic", 2, "kl+0s8L988DsMaSamhPCKx4h9SQlNevV0NJj5gZovI0n68crwrUTcNd29qLCeI3zKxTOCVtGKM7YGa+8HumFMw==", "TIQnnMy8jbc60Gcp0osGmg==", "062123344", 2, "selmaidic" },
                    { 5, true, "Dobrinjska 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(1706), "ajdin.kahrimanovic8@aiesec.com", "Ajdin", 1, "M", "Kahrimanovic", 2, "rwmsNsm0KbMLpX3TEjaIa83ydRcetXRbwt1gjfsOJM2IL0q0xXynfnmUaS9un13x6z2gDrcBW/2gkS3insuyaw==", "IlrTfS3mWupnp5Tg4jsYMg==", "062123344", 3, "ajdinkahrimanovic" },
                    { 6, true, "Doglodi 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 19, 28, 58, 346, DateTimeKind.Local).AddTicks(1809), "emir.zukic@gmail.com", "Emir", 1, "M", "Zukic", 2, "rJ7a+/zJJE2m9AdR4ah4crdZrSMa1do9ES7Sv7meRqghQc4V9B0wcSD+q3QxiN+rMu+c1a316EIlR9YRLEHnIQ==", "TpNLAVpjxKFv3LIIJWHqgw==", "062123344", 2, "emirzukic" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "Address", "Capacity", "CreatedDate", "EstablishmentDate", "LocalCommitteeId" },
                values: new object[,]
                {
                    { 1, true, "Trg Alije Izetbegovica 2", 20, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(5396), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(6585), 1 },
                    { 2, true, "Ulica 3", 10, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7009), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7044), 2 },
                    { 3, true, "Ulica 4", 20, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7065), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7070), 3 },
                    { 4, true, "Ulica 22", 20, new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7081), new DateTime(2021, 7, 4, 19, 28, 58, 322, DateTimeKind.Local).AddTicks(7086), 4 }
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
                name: "Members");

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
