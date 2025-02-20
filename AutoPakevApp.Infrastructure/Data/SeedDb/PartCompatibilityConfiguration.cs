using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoPakevApp.Infrastructure.Data.SeedDb
{
    internal class PartCompatibilityConfiguration : IEntityTypeConfiguration<PartCompatibility>
    {
        public void Configure(EntityTypeBuilder<PartCompatibility> builder)
        {
            var data = new SeedData();

            builder.HasData(data.PartCompatibilities.ToArray());
        }
    }
}
