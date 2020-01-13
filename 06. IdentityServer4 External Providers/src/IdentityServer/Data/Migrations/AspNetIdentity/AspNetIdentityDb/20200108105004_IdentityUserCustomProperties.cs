using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class IdentityUserCustomProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ApiResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 80, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68211baf-8c99-4559-b6a9-3e75026c2186", "AQAAAAEAACcQAAAAEFOURCmvRZGFwfCY6T/Gx/syQasTZYyNJpIeQQm/z0M/L56NlhlygW0g2dbdaVAqZQ==", "85e246c1-161b-48e7-a907-4baba8279459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7520ec33-b5e7-44ed-aa19-ca6fb3ffba36", "AQAAAAEAACcQAAAAEH7+MMsOELTd5tLbJG4I3HN3tXTsdmZV732W/3RJlWMyA+FpuBvapGublTE0MIWGpg==", "3b0cc69f-be9a-449c-9100-b56af88ba38a" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 100, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 100, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 100, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 100, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 101, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 103, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 103, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 68, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 68, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 50, 4, 68, DateTimeKind.Utc).AddTicks(5142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "ApiResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 872, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d6fc3cb-ac89-4734-a12d-1dd7783d3810", "AQAAAAEAACcQAAAAEDByjnfz3toa+nri/qd7n6nvHIUzuDGVbxZQEzhmm0aFPLjhIjfgQ5bJ1ZAmu9zH/w==", "d88cda1d-b6fb-4917-97db-274a7e8a488d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fee7497-c27c-47b7-bc2f-9cf1ae1439fc", "AQAAAAEAACcQAAAAECC8b7byXubnqvPmFuxlih266CVOZ1NGtrfh+iCoEQoVgLvr8UzZvOj3+W9EMOsJpw==", "f37f2bbe-1de3-4d64-bfef-1e1e74d13c33" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 893, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 893, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 893, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 893, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 893, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 896, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 896, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 860, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 860, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 8, 10, 21, 19, 860, DateTimeKind.Utc).AddTicks(3247));
        }
    }
}
