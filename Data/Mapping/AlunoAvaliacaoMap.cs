using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class AlunoAvaliacaoMap : IEntityTypeConfiguration<AlunoAvaliacao>
{
    public void Configure(EntityTypeBuilder<AlunoAvaliacao> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.AlunoTurmaId);
        builder.Property(e => e.AvaliacaoId);
        builder.Property(e => e.Nota);
        builder.Property(e => e.Data);

        builder.HasOne(d => d.AlunoTurma)
            .WithMany(p => p.Avaliacoes)
            .HasForeignKey(d => d.AlunoTurmaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Avaliacao)
            .WithMany(p => p.NotasAlunos)
            .HasForeignKey(d => d.AvaliacaoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
