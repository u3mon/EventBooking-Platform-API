using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(100);
               
        builder.HasData(
            new Category { Id = 1, Name = "Music" },
            new Category { Id = 2, Name = "Sport" },
            new Category { Id = 3, Name = "Education" },
            new Category { Id = 4, Name = "Technology" },
            new Category { Id = 5, Name = "Art" }
        );
    }
}
