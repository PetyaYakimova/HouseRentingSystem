using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "1e0da5de-b66c-4663-995d-39670d00d6e6" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf991206-0ee2-4c36-9486-d9092b2ebbc7", "AQAAAAEAACcQAAAAEGyto1L3tSTOhQnnfGf5KysNfiOsCZI90o2sLBZAxVxhMu31hGN14NOSGD/Bb58ORw==", "6c088f6e-67c2-490c-a46e-a06bc732f7ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e47f3f4-756f-49cf-9417-f59b72aa61f0", "AQAAAAEAACcQAAAAEFAAqAkqWGUc/VFK7/yG1VenwLfQwX4EDs1OX2KVmd1Jvn+goC+mcP/07j7DGUOJ7g==", "ffecdfc7-355f-4b77-bdf0-12668febf38d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e92850a-83ba-47ce-bb37-a5499fb1eb9e", "AQAAAAEAACcQAAAAEMWAy2EfVIsNprToIn7D8AcXNPKTkIXEj5cGgpPOxiX5JBeH8G1/DKqBCiBJsefgug==", "00a19d7d-550f-40a8-a465-464d157668fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d4e76ca-4d29-429b-80aa-17f6b1d671b3", "AQAAAAEAACcQAAAAEN0X15H6l57hQaP2cit/JrqsC37NuSZZ5xXqJX0SfX/cL3q114WcXtGqXVWOZEeHTA==", "5a0814c1-8191-42d7-9ca3-3c00d85655e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb044e0-43ed-4811-a1ba-bba7baadd835", "AQAAAAEAACcQAAAAEFAW7NgKTRNSJberSYw7At42dbemUZpQTQKudrgnL7E6Aa3HRAwQBySvC81AyKggww==", "3920c42b-3add-4236-b85d-feab9fd810ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5f575ec-9f62-4579-a3b2-6f9cdc763514", "AQAAAAEAACcQAAAAEDvh+GSwzTqD+avmDJzYgRDisObizdF4fbgTJU4z4Iodz8SwpP42LUZnZdhDjn4Wbw==", "d1fba994-fc82-428c-9acc-db322a70ca0d" });
        }
    }
}
