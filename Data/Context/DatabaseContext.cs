using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<AlunoAvaliacao> AlunoAvaliacao { get; set; }
        public DbSet<AlunoPresenca> AlunoPresenca { get; set; }
        public DbSet<AlunoTurma> AlunoTurma { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoAvaliacaoMap());
            modelBuilder.ApplyConfiguration(new AlunoPresencaMap());
            modelBuilder.ApplyConfiguration(new AlunoTurmaMap());
            modelBuilder.ApplyConfiguration(new AulaMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new SalaMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
        }
    }
}
