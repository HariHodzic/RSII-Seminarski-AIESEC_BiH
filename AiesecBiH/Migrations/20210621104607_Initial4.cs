using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AiesecBiH.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Member",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "FunctionalFields",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 21, 12, 46, 6, 534, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(7620), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8426), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8451), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8463), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8474), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "LocalCommittees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8485), new DateTime(2021, 6, 21, 12, 46, 6, 537, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 542, DateTimeKind.Local).AddTicks(5755), "y83RC5dtZOKKbEAYSENrNGp/pOcBnNzYYHhpQ5OnJ/lARtJ3cT7FJq71yIMQsO28Nz7bdhBGord/Mzubqe4TKQ==", "nH96bCpJaxjjzGuLiWLxBw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(3331), "eGV2rNiK3cupQmoRIZVjzi+iOSOy4hfC9HEBP3sWgVHjPB7mM+qYpzF/euMkMV2waLhKel9Ge7Jq2Z0wbOfIIg==", "gCwRvLCtgqjBZQAPDIefYA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4161), "sDRxnLdDdLmlQHIPCPY1ElFRSV0M+x+GKBa6xQTcaasfeshlCPnGOS2NSrC/Z6Y7NewLBKq2dndqRz7lcYA97A==", "q1iuMKLxEpqjn7i8NbxRAQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4307), "N1cRixYiedh36zQk0AEWefGCW2UZLwQCUrE16Wb2L0KH60cCH4tF9yK7hizhib11l8ucdNhEMxAcxj4iA65n7g==", "zQ3sIVH6D9wZjXgEO8NDdg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4392), "b3OVHPV1hBfEpM6oLHqQpq1dOxg8zGQV7oNzn3mQqDC6WtnQvgqAhlhS1UZ7GYwfsE6qt/J2xlf6S7oQ5GG/yQ==", "o1gkAcFjXUAejyOFHN+jDQ==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4549), "IG0pDDH96rqlKX2NG64rSkmO6KeBukQNuYf+EmwZA3dLfn5hmUYAF66gQu0u0dMwZ5almPXVwT8XU/mBr2jB7A==", "blcEINELUPhzDmzSqOzy0A==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4622), "6pbeKJwpTgzzujoctIShk6wnJOsqyuz1tZ11Zu0g2i8MN6cEmAnM+ghl7tDw4GjRT9PyowtFC6a1c3pJG8+X3w==", "lC4skDJBX4RlczUt7VCg6A==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4691), "Z8kSs3NuzPoODhnD+n0X9JsL/RlgZSZo8hfJSmG95pg54ATI4EmSEbgFNTGt2MqqZdhasjh5YCP252BMp3OLrA==", "6j+YkHED7O1fn+n3F8YQRw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4806), "AMvoQ2Yv/pi0+XSA/m3I19kaxdSQiStjk3BldKS8toLQRlGWqqaO2RTGU/U/YH5a1cCV1f0rNTidgPJ29K+hTw==", "R2OBpkHB4IBwYdHv2wpyqA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Active", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new DateTime(2021, 6, 21, 12, 46, 6, 548, DateTimeKind.Local).AddTicks(4878), "2zOpHOvgzEkpn0zre35qW+xafSD0VybgmjIpr9baY+OEXRaCxY8TP5qLqdZ8nx+BfCvuja9vbLE5PvqYVohdGA==", "v48fDzPqr/V0PamWt3C/1g==" });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(3732), new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6717), new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6809), new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EstablishmentDate" },
                values: new object[] { new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6825), new DateTime(2021, 6, 21, 12, 46, 6, 538, DateTimeKind.Local).AddTicks(6830) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Member");

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ov70HHTTepsm8Wg/h4XSxZIK1ynNjAsitsqk6+8B0TpzKFHkX5LzXi3EvDLB0nJtFkuf82PU6mZpLeJ3rnYIjA==", "cp2cU81Y3CsRz0jB1vKOyw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "wL+eP7QPApN7T6ocsWFCr2rZ/4VZvH3AGTMB4hDgySgHq1+lqeIj4Oh7oWZd+aj421AMusbBToVbDL1zsxL1cg==", "jWO5QbhGpgbty3Bn9AzVkA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "XnnPKR8U8IUWbyPp9+JMVqw5lGwnUqJffL8zQDethok2g4S1h6rVxU6av31hx0diUJRkC9OGw0ITcXNrifEHYA==", "LQfscyY750ZN1ZFCRPZXsA==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rOcQptdTJCHi59jYAs9MzVY5Nclp+0qxdC74pqkFovGSifl2Ou4Y8ecQrXGASNGHRSiUEMkeyzDIMoBpHxa//w==", "ZaJvXw7roFwN+KHUiaFZOw==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "6pW1yhKo79/dtUPaBDeL9fJbqKi0NldjTbKOlV1eYmyJckEEWOXqEOEN8Yu5CelcrVMCEmRq9WoeuDg3/DIsRA==", "UNEtTnQcGSVGSgh7o9uC2g==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Vnv/SqsfAbn+M8SP/QOH1/g+i7XAcJPtPnAUdEtTJvOx9+eCo71Ru3lqwMIIV3uIXQRp+VVcdsDRbJmVg8fxDA==", "EL+YrXcVp3q7xkOuBII85w==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aPGQBED3L3HoA2iVXsOKRbF+48Fs5KlzEmFhLgQdwc5HoLnQAVv209vrn4cdC90ykmk9wpX7UXVSBaSXZ4pE3g==", "P6uFJD8jfu32gXjPOPGYqg==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "11GWFXiApm6OlSdSKOV0HOLXnY84nhnxhtBiuRGRriemoWh1tgcTeT4HO+bYorYmmai+68m98qYEo+IQV6ihUQ==", "SjuDfwV9Jav2ORl0++ow9g==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "N/KcIBc4LGW6tpH/mtBV4SOQ1pcbNX0yvxlnLnGf36omZlTMWPDAgiNstxgMN94rF3pBmHCkabnhIbJ7qRTAVw==", "bFkzhtjOBEBNrFOkI988+Q==" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IPEyJ/S0cQv7p8jo9tYFK14BcWOjGROhFvDwqjuRVfta8DgauR/tcae7Xnb7vSajFbRbdYiBRDNyBQj9LMjvoA==", "2WH5D0v0JR2nxeH9MXVn/Q==" });

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
        }
    }
}
