namespace Domain.ViewModel;

public class TurmaViewModel
{
    public Guid Id { get; set; }
    public Guid DisciplinaId { get; set; }
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }

    public ICollection<AvaliacaoViewModel> Avaliacoes { get; set; }
    public ICollection<AlunoTurmaViewModel> Alunos { get; set; }
    public ICollection<AulaViewModel> Aulas { get; set; }
}
