using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public class AlunoPresencaMap : IEntityTypeConfiguration<AlunoPresenca>
{
    public void Configure(EntityTypeBuilder<AlunoPresenca> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.AlunoTurmaId);
        builder.Property(e => e.AulaId);
        builder.Property(e => e.Presenca).IsRequired();

        builder.HasOne(d => d.AlunoTurma)
            .WithMany(p => p.Presencas)
            .HasForeignKey(d => d.AlunoTurmaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Aula)
            .WithMany(p => p.AlunosPresenca)
            .HasForeignKey(d => d.AulaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}