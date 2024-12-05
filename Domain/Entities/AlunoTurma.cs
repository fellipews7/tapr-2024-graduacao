namespace Domain.Entities
{
    public class AlunoTurma
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid TurmaId { get; set; }

        public Turma Turma { get; set; }
        public ICollection<AlunoAvaliacao> Avaliacoes { get; set; }
        public ICollection<AlunoPresenca> Presencas { get; set; }
    }
}
