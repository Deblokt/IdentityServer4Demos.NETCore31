using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class FidoStoredCredentialAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FidoStoredCredential",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    UserId = table.Column<byte[]>(nullable: true),
                    PublicKey = table.Column<byte[]>(nullable: true),
                    UserHandle = table.Column<byte[]>(nullable: true),
                    SignatureCounter = table.Column<long>(nullable: false),
                    CredType = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    AaGuid = table.Column<Guid>(nullable: false),
                    DescriptorJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FidoStoredCredential", x => x.Username);
                });

            migrationBuilder.UpdateData(
                table: "ApiResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 339, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b9c2fa-e723-4c5a-892e-d091b358fb63", "AQAAAAEAACcQAAAAEFNWXTm1k2560i59xPpdirKElZnW3Y4nNYYqj2KyAcXMjsTHBOzJldY8WmzttEQ/Gg==", "140ba6d2-3fe6-4ab4-a1e4-18c7f0cdfc69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b3e1572-5ca2-484d-ba7e-24455e2e47cb", "AQAAAAEAACcQAAAAEH4CAPtQlpfzMa966P+7g5G5GDT0zMjJyiTFsA671DfkIcBDYg960tuq9bSQI6Asrg==", "ea6a4766-cb66-40ee-8182-37702d2c60b6" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 360, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 360, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 360, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 360, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 360, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 363, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ClientSecret",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 363, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 326, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 327, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 9, 14, 42, 53, 327, DateTimeKind.Utc).AddTicks(241));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FidoStoredCredential");

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
    }
}
