using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Nome).HasMaxLength(100);
        builder.Property(e => e.Descricao).HasMaxLength(500);
        builder.Property(e => e.CargaHoraria);
        builder.Property(e => e.CursoId);

        builder.HasOne(d => d.Curso)
            .WithMany(p => p.Disciplinas)
            .HasForeignKey(d => d.CursoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
