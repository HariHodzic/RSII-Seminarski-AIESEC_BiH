using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 525, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 526, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 526, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 526, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 526, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 19, 2, 2, 18, 526, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(8985), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9735), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9759), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9770), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9781), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9791), new DateTime(2021, 6, 19, 2, 2, 18, 528, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "ov70HHTTepsm8Wg/h4XSxZIK1ynNjAsitsqk6+8B0TpzKFHkX5LzXi3EvDLB0nJtFkuf82PU6mZpLeJ3rnYIjA==", "cp2cU81Y3CsRz0jB1vKOyw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "wL+eP7QPApN7T6ocsWFCr2rZ/4VZvH3AGTMB4hDgySgHq1+lqeIj4Oh7oWZd+aj421AMusbBToVbDL1zsxL1cg==", "jWO5QbhGpgbty3Bn9AzVkA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "XnnPKR8U8IUWbyPp9+JMVqw5lGwnUqJffL8zQDethok2g4S1h6rVxU6av31hx0diUJRkC9OGw0ITcXNrifEHYA==", "LQfscyY750ZN1ZFCRPZXsA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "rOcQptdTJCHi59jYAs9MzVY5Nclp+0qxdC74pqkFovGSifl2Ou4Y8ecQrXGASNGHRSiUEMkeyzDIMoBpHxa//w==", "ZaJvXw7roFwN+KHUiaFZOw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "6pW1yhKo79/dtUPaBDeL9fJbqKi0NldjTbKOlV1eYmyJckEEWOXqEOEN8Yu5CelcrVMCEmRq9WoeuDg3/DIsRA==", "UNEtTnQcGSVGSgh7o9uC2g==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "Vnv/SqsfAbn+M8SP/QOH1/g+i7XAcJPtPnAUdEtTJvOx9+eCo71Ru3lqwMIIV3uIXQRp+VVcdsDRbJmVg8fxDA==", "EL+YrXcVp3q7xkOuBII85w==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "F", "aPGQBED3L3HoA2iVXsOKRbF+48Fs5KlzEmFhLgQdwc5HoLnQAVv209vrn4cdC90ykmk9wpX7UXVSBaSXZ4pE3g==", "P6uFJD8jfu32gXjPOPGYqg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "11GWFXiApm6OlSdSKOV0HOLXnY84nhnxhtBiuRGRriemoWh1tgcTeT4HO+bYorYmmai+68m98qYEo+IQV6ihUQ==", "SjuDfwV9Jav2ORl0++ow9g==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "M", "N/KcIBc4LGW6tpH/mtBV4SOQ1pcbNX0yvxlnLnGf36omZlTMWPDAgiNstxgMN94rF3pBmHCkabnhIbJ7qRTAVw==", "bFkzhtjOBEBNrFOkI988+Q==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { "F", "IPEyJ/S0cQv7p8jo9tYFK14BcWOjGROhFvDwqjuRVfta8DgauR/tcae7Xnb7vSajFbRbdYiBRDNyBQj9LMjvoA==", "2WH5D0v0JR2nxeH9MXVn/Q==" });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 529, DateTimeKind.Local).AddTicks(7378), new DateTime(2021, 6, 19, 2, 2, 18, 531, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2088), new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2217), new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2242), new DateTime(2021, 6, 19, 2, 2, 18, 532, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Abbreviation", "Name" },
                values: new object[] { "Admin", "Administrator" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Abbreviation",
                value: "TM");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Abbreviation", "Name" },
                values: new object[] { "TL", "TeamLeader" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 4, "P", "President" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Member",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Member",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Member",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "UASt7Yuvean5dUK2t+1sGfcN4NVO/M7mcMZQJV7JWzC5jPvPjuuk/qQNaYkXjyUGd7Hh3XrG6zmLE4PIl48QTQ==", "/5MMnj9G7tat4agWY1mvGQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "1k0SmmauRkctgtDk8+BHKHad1JHJsrXiww5ikWhGlP8pgl26wlpu1VhigAng1V1s3Ie7RGjoRNoJtxPbvdu+1A==", "ZiNaaFVn/dfq0Aq84EXubg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "XjMvlgCgWuHL33MmKuGUxoj4EjCNxKt+VHWZos0X9PD/8j4vntyNiXBiBhiDNq1XX7y72fI7i8Pby3CU9OoUig==", "xLE+ew5yMgQoro7v4H5DDg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "4FJkBAFu5ctdBHHpV0YjkgVP4I7swx/fc+S4Hro8FoJ8AmMoAMtITJD9QjMUvoYDB5pWXEgszISi/VsK+6ifSg==", "E9Q4h3Tsvy6sSCee2g0IAg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "S4cB3EUbSHxXKEwC3+gjF+8WdG/LdqGWK6NWPkbc+pYo7RNumKNqKdftLeZbQVuwQrhvf1/Lz44pqgqjwnQWCw==", "MKBhWoAbfrtlIuiWFY0wTg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "U6hQqhjjDy2xRhBRlQkeYqnGehiDtuUutqtmvGlciqdCJXxXQrxYu+3WtUTcWQw+9dqmtd1bbGXFo9mQY0f0IQ==", "n8COBce/qDSeSSAle4SpEA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "S4beNmJCLeLelNlpWc2J00KWuMeIugHt+blA5qCsO4u/Lr26Hnh+smqH9NZNzk1lli43a38T54HN9k2RK9C/qQ==", "SZ3AlfdMhMv/0peeeQzOsg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "HCSKMRYKzLSLQMueTN2SOpqMxc8rGtqAgFq0mRMcK7F9U1DxXZYpRKEaexS8kwXr2SPXu9rCe2b9qJV5ZNnY8A==", "+0id4s88uU8Xm9gAo1NIdg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "aHoQzGsmjK52vyLQE9kCXUMivjmG0SEqc/ybcEzfRQlysnMTXEQ+XEL6lr0M1jx0EUC1TNzyfb8CCbuBaLOQpw==", "qGF17h9rJHchC2tDDrSbhQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt" },
                values: new object[] { " ", "eZksDryZcrLy1UJHuPYLBw49Q0kes8G4dc0N9Yu2Z9jvi36VcIie8nuy+r1TJI8iigQfWyWZykykLq67EpUWIg==", "1iVDLPPi8AAD3nJyCwIQKA==" });

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Leader");
        }
    }
}
