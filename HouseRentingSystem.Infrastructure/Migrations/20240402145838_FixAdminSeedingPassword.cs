using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class FixAdminSeedingPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0786b8ed-f447-4aca-b142-6440726c5fc9", null, "54336e61-8d00-46cc-a8c9-d3449101c339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8854c7c6-4627-41b1-a1d2-f7159f1f99e8", "AQAAAAEAACcQAAAAEAscHNxjdlDSAIp/QxDvvtozIDgnez1IRuJBQn1WKFCUu0e1nwzdJ9d7qndLvI4WYg==", "737f07c7-e273-4f34-bd2a-16fd05db02c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083c05cb-f7bb-40de-a12b-45efe3284631", "AQAAAAEAACcQAAAAELZ9EcI+w4FA4iByAOfUeAC9ioo3dd0TPJV3f+50Tp202H73zBr6xYQLjJxcDmLAhg==", "fa10bdd5-77d3-4cea-81a0-225265f50266" });
        }
    }
}
