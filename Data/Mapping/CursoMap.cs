using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class CursoMap : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.Property(e => e.Nome).HasMaxLength(150);
        builder.Property(e => e.Duracao).IsRequired();
        builder.Property(e => e.Tipo).HasConversion<string>().HasMaxLength(50);
    }
}
