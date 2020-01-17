using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class FidoStoredCredentials : Migration
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf74388-9f15-4db8-ae76-03a5e1dec8ec", "AQAAAAEAACcQAAAAEFKxl9dFfppA3t28QnZkwveDhaZBllzcSGBwz8lzBiUXXgESlE2fpMJ6t0Gl+xUuPw==", "c0b266f0-f629-4109-b19f-e11cb5209cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5e1390-6163-4afe-8695-0d6a68ea1b5e", "AQAAAAEAACcQAAAAEHSAZ2iv2OovcuAqWvykUGx8EjQ4tqQnoPJQz92pgav5tX44bDwVUiupcJoE6NQHJw==", "9493d91d-d043-4790-b229-171537d82f7d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FidoStoredCredential");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0a35694-75ca-4311-9643-9da268c7afa2", "AQAAAAEAACcQAAAAECn7ZlhsqAr80v4sx2JaC1nexo7eLHpJLJWPZf33UTdCnuVU+6oZlYP+hCjIdY0eGA==", "41c9cd78-af8e-4322-bed2-3d24aab76c11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5169d19a-8245-4b5e-8904-4b7467d3c66f", "AQAAAAEAACcQAAAAEMzBspjI8hrajuA8TslkUgqTyv3LF2aS4yGTOj8t9BdrS6P5ZmIlEwI99Xz8hg7XzQ==", "e8e180ae-4120-4677-bfbd-b3f9859a322e" });
        }
    }
}
