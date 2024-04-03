using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedHouseAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d88b55-eef7-47a0-acee-4636471292ad", "AQAAAAEAACcQAAAAEJ0SmzspYke/iyfHJt+JWrdwwArFrmadCIy0kPOqwwbq9NSrfVigIAwTS29aDX11tg==", "dd4b8793-9757-4ae6-b326-654fedcb0c21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973c45b7-b884-41e5-96db-c52494ac3c84", "AQAAAAEAACcQAAAAEFbVvInct00Vuh87H496HaC055xDpGToHjsJ5eicXB6izCCquGUFN2SFUeCqJDJ03Q==", "52d3dc6d-242f-4d5e-925b-7c08b099560c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "249c2551-bbe2-49fc-85a4-9fb14b91c8ef", "AQAAAAEAACcQAAAAEHg/QOHsOHsaK17dCK0NknA/U7/G8PmFrFCN4ljxttbUWaylZYBlvQgupRU5pbw0mg==", "2ad6aa49-371a-475d-b942-37bfb598d7d5" });
        }
    }
}
