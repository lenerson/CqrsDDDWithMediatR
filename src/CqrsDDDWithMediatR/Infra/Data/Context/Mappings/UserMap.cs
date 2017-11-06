using CqrsDDDWithMediatR.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CqrsDDDWithMediatR.Infra.Data.Context.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(x => x.Id);
            builder
                .Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(x => x.Password)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
