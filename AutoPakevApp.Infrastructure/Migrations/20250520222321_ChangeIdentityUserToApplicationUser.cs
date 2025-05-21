using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPakevApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdentityUserToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-abcd-1234-efgh-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bcbe1bc-4b3e-4282-9127-ce1f3dce3b16", "AQAAAAIAAYagAAAAEMMbY6C1+NrUO6iAz85gTuq0cnG2RCxXBqn2XIIiO1ZrW8XieC36IUYCXLVYS0hG3A==", "0559454f-119c-48a8-b5d7-5755b527694a" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 20, 22, 23, 20, 568, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 20, 22, 23, 20, 568, DateTimeKind.Utc).AddTicks(6144));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-abcd-1234-efgh-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a9109b5-5eb4-4974-8d1f-fc9a5914539e", "AQAAAAIAAYagAAAAEO2bLG/FZItFYy5j18j1U9hmajMSzU4XUO94sFK/BgQYyMVsWJEjWuY5x9fatCvMxw==", "ac25c938-9c29-42db-9781-820c6b4274e2" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 20, 12, 27, 31, 158, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 20, 12, 27, 31, 158, DateTimeKind.Utc).AddTicks(4747));
        }
    }
}
