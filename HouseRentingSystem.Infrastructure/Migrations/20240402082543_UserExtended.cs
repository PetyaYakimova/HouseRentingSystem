using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f00cac-6eff-4877-9254-1323f9b4f984", "", "", "AQAAAAEAACcQAAAAEK7t+oqUhZnJW+yHoJI02AlMoaXPVIJyRw6FAyq4GDIK47nAh2WROiFCMrZA4Uj3OA==", "bae7d929-e93f-4fc4-8749-9d41ea07d228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce0396e-a367-431a-95aa-f022f7427cbe", "", "", "AQAAAAEAACcQAAAAEBQ4sA3ntF4HwHUnAOPdOj7gBLSEgVbBpXYCSPCq2ch2P9H8pR3f6iJpH5JRXTb6kQ==", "b15d4dd9-f0a1-4e29-8217-0e123c0f46e7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71ce2c39-ebaa-49c6-ae14-f7c239c55dd3", "AQAAAAEAACcQAAAAEGrBeNzmD2tfJEbTjigkEPRSb4VXZz5xzBQrnmhPcSdUokC2GCI2a6xQPQb76L6NoQ==", "c6a01aca-b0eb-4744-8018-d587c1175a39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e58d65e-a964-48b0-8dce-2d1d1fa53880", "AQAAAAEAACcQAAAAEDPGhi7OqZMgALQx5/JS930hNw2oMf7tpQTeXkhGSHNlohsfjIqxe2jkPlGOL+IRbQ==", "18594aa0-3522-447b-a162-13bf90e9112d" });
        }
    }
}
