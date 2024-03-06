using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ac7d98-62de-4b0c-bd52-19ba8b647d26", "AQAAAAEAACcQAAAAEOD/lcuAqUS5fcdgZb/W+p14mKpwa0RLbX91ngfklQeIy1pXONEIIzrI2vmAmXl8ZA==", "909f2362-e004-4409-9c72-595fa14fed80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea9bd5f8-8ba0-4f20-a921-cb735ec61b02", "AQAAAAEAACcQAAAAEOZ20aoK1k7+KtDKPlygG4zGvJKgTOp5BWHNjGWt6UxFoMNcFl24TkA8cI1FRTgTwg==", "e52bfd74-9865-4605-858c-246767d86418" });
        }
    }
}
