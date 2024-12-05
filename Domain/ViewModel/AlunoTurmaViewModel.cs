namespace Domain.ViewModel
{
    public class AlunoTurmaViewModel
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid TurmaId { get; set; }

        public ICollection<AlunoAvaliacaoViewModel> Avaliacoes { get; set; }
        public ICollection<AlunoPresencaViewModel> Presencas { get; set; }
    }
}
