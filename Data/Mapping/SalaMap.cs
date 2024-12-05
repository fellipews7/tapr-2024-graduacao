using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class SalaMap : IEntityTypeConfiguration<Sala>
{
    public void Configure(EntityTypeBuilder<Sala> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Nome).HasMaxLength(100);
        builder.Property(e => e.Codigo).HasMaxLength(50);
        builder.Property(e => e.Capacidade);
        builder.Property(e => e.Tipo).IsRequired();

        builder.HasIndex(e => e.Codigo).IsUnique();
    }
}
