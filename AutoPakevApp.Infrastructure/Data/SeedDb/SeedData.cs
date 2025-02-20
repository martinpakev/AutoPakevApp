using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static AutoPakevApp.Infrastructure.Constants.CustomClaims;

namespace AutoPakevApp.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public ApplicationUser User { get; set; }
        public IdentityUserClaim<string> UserClaim { get; set; }
        public List<Category> Categories { get; set; }
        public List<Part> Parts { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Brand> Brands { get; set; }
        public List<CarModel> CarModels { get; set; }
        public List<PartCompatibility> PartCompatibilities { get; set; }

        public SeedData()
        {
            SeedUser();
            SeedCategories();
            SeedBrands();
            SeedCarModels();
            SeedParts();
            SeedOrders();
            SeedOrderItems();
            SeedPartCompatibilities();
        }

        private void SeedUser()
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            User = new ApplicationUser()
            {
                Id = "12345678-abcd-1234-efgh-56789abcdef0",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "USER@MAIL.COM",
                FirstName = "Great",
                LastName = "Admin"
            };
           
            UserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Great Admin",
                UserId = User.Id
            };

            User.PasswordHash = hasher.HashPassword(User, "admin123");
        }

        private void SeedCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Engine Parts" },
                new Category { Id = 2, Name = "Brakes" },
                new Category { Id = 3, Name = "Suspension" },
                new Category { Id = 4, Name = "Exhaust" },
                new Category { Id = 5, Name = "Electronics" },
                new Category { Id = 6, Name = "Tires & Wheels" },
                new Category { Id = 7, Name = "Interior" },
                new Category { Id = 8, Name = "Exterior" }
            };
        }

        private void SeedBrands()
        {
            Brands = new List<Brand>
            {
                new Brand { Id = 1, Name = "Toyota" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Audi" }
            };
        }

        private void SeedCarModels()
        {
            CarModels = new List<CarModel>
            {
                new CarModel { Id = 1, Name = "Corolla", Year = 2020, BodyType = "Sedan", EngineType = "Petrol", BrandId = 1 },
                new CarModel { Id = 2, Name = "Camry", Year = 2021, BodyType = "Sedan", EngineType = "Hybrid", BrandId = 1 },
                new CarModel { Id = 3, Name = "X5", Year = 2022, BodyType = "SUV", EngineType = "Diesel", BrandId = 2 }
            };
        }

        private void SeedParts()
        {
            Parts = new List<Part>
{
                new Part { Id = 1, Name = "Brake Pads", Description = "High-performance brake pads for smooth stopping.", Price = 50.00M, CategoryId = 2, StockQuantity = 10 },
                new Part { Id = 2, Name = "Oil Filter", Description = "Durable oil filter for better engine protection.", Price = 15.00M, CategoryId = 1, StockQuantity = 10},
                new Part { Id = 3, Name = "Spark Plug", Description = "Premium spark plug for optimal engine performance.", Price = 10.00M, CategoryId = 1, StockQuantity = 10 },
                new Part { Id = 4, Name = "Exhaust Muffler", Description = "Stainless steel muffler for reduced noise.", Price = 120.00M, CategoryId = 4, StockQuantity = 10 },
                new Part { Id = 5, Name = "Car Battery", Description = "Long-lasting car battery with high cold cranking amps.", Price = 180.00M, CategoryId = 5, StockQuantity = 10 }
            };

        }

        private void SeedOrders()
        {
            Orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    UserId = User.Id,
                    TotalPrice = 65.00M,
                    OrderDate = DateTime.UtcNow,
                },
                new Order
                {
                    Id = 2,
                    UserId = User.Id,
                    TotalPrice = 180.00M,
                    OrderDate = DateTime.UtcNow,
                }
            };
        }

        private void SeedOrderItems()
        {
            OrderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 1,
                    OrderId = 1,
                    PartId = 1,
                    Quantity = 1,
                    Price = 50.00M
                },

                new OrderItem
                {
                    Id = 2,
                    OrderId = 1,
                    PartId = 2,
                    Quantity = 1,
                    Price = 15.00M
                },

                new OrderItem
                {
                    Id = 3,
                    OrderId = 2,
                    PartId = 5,
                    Quantity = 1,
                    Price = 180.00M 
                }
            };


        }

        private void SeedPartCompatibilities()
        {
            PartCompatibilities = new List<PartCompatibility>
            {
                new PartCompatibility { Id = 1, PartId = 1, CarModelId = 1 }, // Brake Pads for Corolla
                new PartCompatibility { Id = 2, PartId = 2, CarModelId = 2 }, // Oil Filter for Camry
                new PartCompatibility { Id = 3, PartId = 4, CarModelId = 3 }  // Exhaust Muffler for X5
            };
        }
    }
}
