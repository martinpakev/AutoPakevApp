using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoPakevApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "12345678-abcd-1234-efgh-56789abcdef0", 0, "", "8b89b907-daa3-4cda-bae1-b3e8c451a82d", "admin@mail.com", false, "Great", "Admin", false, null, "USER@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEIu+jEXEh5Ym8ubJWZkfek1ZJKdnj4w6LgcucKWXhk4wOAZ06aA36/FdBgvPTb7VVQ==", null, false, "dac7efc3-77f5-4f49-8261-d664ea70f848", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "BMW" },
                    { 3, "Audi" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Engine Parts" },
                    { 2, "Brakes" },
                    { 3, "Suspension" },
                    { 4, "Exhaust" },
                    { 5, "Electronics" },
                    { 6, "Tires & Wheels" },
                    { 7, "Interior" },
                    { 8, "Exterior" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "user:fullname", "Great Admin", "12345678-abcd-1234-efgh-56789abcdef0" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "BodyType", "BrandId", "EngineType", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Sedan", 1, "Petrol", "Corolla", 2020 },
                    { 2, "Sedan", 1, "Hybrid", "Camry", 2021 },
                    { 3, "SUV", 2, "Diesel", "X5", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 17, 58, 42, 566, DateTimeKind.Utc).AddTicks(8669), 65.00m, "12345678-abcd-1234-efgh-56789abcdef0" },
                    { 2, new DateTime(2025, 2, 20, 17, 58, 42, 566, DateTimeKind.Utc).AddTicks(8672), 180.00m, "12345678-abcd-1234-efgh-56789abcdef0" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 2, "High-performance brake pads for smooth stopping.", "Brake Pads", 50.00m, 10 },
                    { 2, 1, "Durable oil filter for better engine protection.", "Oil Filter", 15.00m, 10 },
                    { 3, 1, "Premium spark plug for optimal engine performance.", "Spark Plug", 10.00m, 10 },
                    { 4, 4, "Stainless steel muffler for reduced noise.", "Exhaust Muffler", 120.00m, 10 },
                    { 5, 5, "Long-lasting car battery with high cold cranking amps.", "Car Battery", 180.00m, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "PartId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 50.00m, 1 },
                    { 2, 1, 2, 15.00m, 1 },
                    { 3, 2, 5, 180.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "PartCompatibilities",
                columns: new[] { "Id", "CarModelId", "PartId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartCompatibilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartCompatibilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PartCompatibilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-abcd-1234-efgh-56789abcdef0");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
