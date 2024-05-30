using AgriConnect.Domain.Products;
using AgriConnect.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriConnect.Infrastructure.Configurations;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
         builder.ToTable("products");

         builder.HasKey(product => product.Id);
         
         builder.Property(product=> product.Name)
             .HasConversion(name => name.Value, value => new ProductName(value));
         
         builder.Property(user => user.Photo) 
             .HasConversion(photo => photo.Value, value => new Photo(value)); 
         
         builder.Property(product => product.Category)
             .HasConversion(category => category.Value, value => new Category(value));
         
         builder.Property( product => product.ProductionDateUtc);
         
       

    }
}