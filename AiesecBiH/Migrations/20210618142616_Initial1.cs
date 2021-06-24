using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 16, 26, 15, 199, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(3393), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4620), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4667), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4689), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4710), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4730), new DateTime(2021, 6, 18, 16, 26, 15, 203, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UASt7Yuvean5dUK2t+1sGfcN4NVO/M7mcMZQJV7JWzC5jPvPjuuk/qQNaYkXjyUGd7Hh3XrG6zmLE4PIl48QTQ==", "/5MMnj9G7tat4agWY1mvGQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "1k0SmmauRkctgtDk8+BHKHad1JHJsrXiww5ikWhGlP8pgl26wlpu1VhigAng1V1s3Ie7RGjoRNoJtxPbvdu+1A==", "ZiNaaFVn/dfq0Aq84EXubg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "XjMvlgCgWuHL33MmKuGUxoj4EjCNxKt+VHWZos0X9PD/8j4vntyNiXBiBhiDNq1XX7y72fI7i8Pby3CU9OoUig==", "xLE+ew5yMgQoro7v4H5DDg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4FJkBAFu5ctdBHHpV0YjkgVP4I7swx/fc+S4Hro8FoJ8AmMoAMtITJD9QjMUvoYDB5pWXEgszISi/VsK+6ifSg==", "E9Q4h3Tsvy6sSCee2g0IAg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "S4cB3EUbSHxXKEwC3+gjF+8WdG/LdqGWK6NWPkbc+pYo7RNumKNqKdftLeZbQVuwQrhvf1/Lz44pqgqjwnQWCw==", "MKBhWoAbfrtlIuiWFY0wTg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "U6hQqhjjDy2xRhBRlQkeYqnGehiDtuUutqtmvGlciqdCJXxXQrxYu+3WtUTcWQw+9dqmtd1bbGXFo9mQY0f0IQ==", "n8COBce/qDSeSSAle4SpEA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "S4beNmJCLeLelNlpWc2J00KWuMeIugHt+blA5qCsO4u/Lr26Hnh+smqH9NZNzk1lli43a38T54HN9k2RK9C/qQ==", "SZ3AlfdMhMv/0peeeQzOsg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HCSKMRYKzLSLQMueTN2SOpqMxc8rGtqAgFq0mRMcK7F9U1DxXZYpRKEaexS8kwXr2SPXu9rCe2b9qJV5ZNnY8A==", "+0id4s88uU8Xm9gAo1NIdg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aHoQzGsmjK52vyLQE9kCXUMivjmG0SEqc/ybcEzfRQlysnMTXEQ+XEL6lr0M1jx0EUC1TNzyfb8CCbuBaLOQpw==", "qGF17h9rJHchC2tDDrSbhQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "eZksDryZcrLy1UJHuPYLBw49Q0kes8G4dc0N9Yu2Z9jvi36VcIie8nuy+r1TJI8iigQfWyWZykykLq67EpUWIg==", "1iVDLPPi8AAD3nJyCwIQKA==" });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(317), new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3309), new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3359), new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3374), new DateTime(2021, 6, 18, 16, 26, 15, 204, DateTimeKind.Local).AddTicks(3378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 18, 15, 57, 8, 344, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(3772), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4632), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4658), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4670), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4682), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4694), new DateTime(2021, 6, 18, 15, 57, 8, 353, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "7uCzMk91WqCBdxHADlx3sg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "qotijbhmLmOz88544dUHYA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "tnuMgcPKaH/DEmyJAc+Vkg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "6i/aHMwG8iBX+wU8zwuoyQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "uCY3d1SXRoO/9bUR254zng==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "SjIuPg3wazh3jWIZqBcxpQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "42/+Rt13D2eNRN0XOfRRQw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "Sj8MSuE5Hn2ma5fBbrXpyQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "Sj8MSuE5Hn2ma5fBbrXpyQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zPvg7ssJjnODUXvkogH3nCjFvYImEnZieGQnSaHpGRbLWkm/IcVjONHtveet4vIx7Ja65unbw8zWhtY1bw0Nww==", "8+tvUWvHfukpPc4o7eLryA==" });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(1090), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4352), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4410), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4427), new DateTime(2021, 6, 18, 15, 57, 8, 354, DateTimeKind.Local).AddTicks(4431) });
        }
    }
}
