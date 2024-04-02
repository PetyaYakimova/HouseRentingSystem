using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8854c7c6-4627-41b1-a1d2-f7159f1f99e8", "Guest", "Guestov", "AQAAAAEAACcQAAAAEAscHNxjdlDSAIp/QxDvvtozIDgnez1IRuJBQn1WKFCUu0e1nwzdJ9d7qndLvI4WYg==", "737f07c7-e273-4f34-bd2a-16fd05db02c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083c05cb-f7bb-40de-a12b-45efe3284631", "Agent", "007", "AQAAAAEAACcQAAAAELZ9EcI+w4FA4iByAOfUeAC9ioo3dd0TPJV3f+50Tp202H73zBr6xYQLjJxcDmLAhg==", "fa10bdd5-77d3-4cea-81a0-225265f50266" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e0da5de-b66c-4663-995d-39670d00d6e6", 0, "0786b8ed-f447-4aca-b142-6440726c5fc9", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", null, null, false, "54336e61-8d00-46cc-a8c9-d3449101c339", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359777777777", "1e0da5de-b66c-4663-995d-39670d00d6e6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6");

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
    }
}
