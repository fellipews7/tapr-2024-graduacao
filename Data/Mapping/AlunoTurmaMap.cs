using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class AlunoTurmaMap : IEntityTypeConfiguration<AlunoTurma>
{
    public void Configure(EntityTypeBuilder<AlunoTurma> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.UsuarioId);
        builder.Property(e => e.TurmaId);

        builder.HasOne(d => d.Turma)
            .WithMany(p => p.Alunos)
            .HasForeignKey(d => d.TurmaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}