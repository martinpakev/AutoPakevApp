using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AutoPakevApp.Infrastructure.Data.SeedDb
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            var data = new SeedData();

            builder.HasData(data.Brands.ToArray());
        }
    }
}
