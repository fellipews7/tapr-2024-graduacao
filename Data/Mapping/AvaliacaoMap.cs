using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
{
    public void Configure(EntityTypeBuilder<Avaliacao> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.TurmaId);
        builder.Property(e => e.Nome).HasMaxLength(100);
        builder.Property(e => e.Descricao).HasMaxLength(500);
        builder.Property(e => e.Peso);

        builder.HasOne(d => d.Turma)
            .WithMany(p => p.Avaliacoes)
            .HasForeignKey(d => d.TurmaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}