using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPakevApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "ShoppingCartItem Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Foreign Key to the Part added to the Shopping car."),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Application User Identifier"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the part added to the Shopping cart.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarItems_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarItems_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Represents an individual item added to a user's shopping cart");

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

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarItems_ApplicationUserId",
                table: "ShoppingCarItems",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarItems_PartId",
                table: "ShoppingCarItems",
                column: "PartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-abcd-1234-efgh-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b89b907-daa3-4cda-bae1-b3e8c451a82d", "AQAAAAIAAYagAAAAEIu+jEXEh5Ym8ubJWZkfek1ZJKdnj4w6LgcucKWXhk4wOAZ06aA36/FdBgvPTb7VVQ==", "dac7efc3-77f5-4f49-8261-d664ea70f848" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 2, 20, 17, 58, 42, 566, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 2, 20, 17, 58, 42, 566, DateTimeKind.Utc).AddTicks(8672));
        }
    }
}
