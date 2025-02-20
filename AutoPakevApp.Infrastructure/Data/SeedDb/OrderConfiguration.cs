using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoPakevApp.Infrastructure.Data.SeedDb
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var data = new SeedData();

            builder.HasData(data.Orders.ToArray());
        }
    }
}
