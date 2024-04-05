using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class RenterUserFKAddedAndFixedCOlumnNameForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "User identifier of the renter",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User identifier of the renter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0da5de-b66c-4663-995d-39670d00d6e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ce0e527-390c-469e-88a7-5022e128b93f", "AQAAAAEAACcQAAAAEEiKHkp/+sRJJu6+uEmKYfEDZ0KqH48OwZvWTF7+tDkKI7tF6kC/6nvwEsV9yrurKw==", "13c43077-3bae-4e56-812e-14e62d992e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cda22c1-7364-4411-b3e4-e6ae61d6d44f", "AQAAAAEAACcQAAAAEPo+yH4ECNoiPqcYsp+7yHRJlX9jfMZaJLlot1GYBPHqdPfMHJmQI67OI5GOSTJgJw==", "664871c7-bc2d-4187-bac3-c3d766bf5294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f398c825-bfd2-4a7b-a268-3ff43bcbf209", "AQAAAAEAACcQAAAAEOMG4xAMahVnmHmJto7s14xtV/mWQqZH/HtqIYSO4as/TaTBk8iluaDCT38Le259aw==", "1271d785-a5d6-4eac-8c1f-0dbef9085eea" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User identifier of the renter",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "User identifier of the renter");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
