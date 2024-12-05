using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class AulaMap : IEntityTypeConfiguration<Aula>
{
    public void Configure(EntityTypeBuilder<Aula> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.TurmaId);
        builder.Property(e => e.SalaId);
        builder.Property(e => e.Nome).HasMaxLength(100);
        builder.Property(e => e.Descricao).HasMaxLength(500);
        builder.Property(e => e.Data).IsRequired();

        builder.HasOne(d => d.Turma)
            .WithMany(p => p.Aulas)
            .HasForeignKey(d => d.TurmaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Sala)
            .WithMany(p => p.Aulas)
            .HasForeignKey(d => d.SalaId)
            .OnDelete(DeleteBehavior.Restrict   );
    }
}
