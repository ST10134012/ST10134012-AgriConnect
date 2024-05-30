using AgriConnect.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriConnect.Infrastructure.Configurations;

public sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");
        
        builder.HasKey(role => role.Id);
        
        builder.Property(role => role.Id)
            .ValueGeneratedNever();
        
        builder.HasMany(role=> role.Users)
            .WithOne(u=> u.Role)
            .HasForeignKey(u=> u.RoleId);

        builder.HasData(Role.Employee, Role.Farmer); 
    }
}