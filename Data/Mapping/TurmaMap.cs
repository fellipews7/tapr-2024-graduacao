using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class TurmaMap : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.DisciplinaId);
        builder.Property(e => e.Nome).HasMaxLength(20);
        builder.Property(e => e.DataInicio).IsRequired();
        builder.Property(e => e.DataFim);

        builder.HasOne(d => d.Disciplina)
            .WithMany(p => p.Turmas)
            .HasForeignKey(d => d.DisciplinaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
