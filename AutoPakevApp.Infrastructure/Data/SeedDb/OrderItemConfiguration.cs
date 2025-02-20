using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoPakevApp.Infrastructure.Data.SeedDb
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            var data = new SeedData();

            builder.HasData(data.OrderItems.ToArray());
        }
    } 
}
