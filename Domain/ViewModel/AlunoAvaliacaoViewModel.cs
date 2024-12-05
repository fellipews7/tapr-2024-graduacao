namespace Domain.ViewModel;

public class AlunoAvaliacaoViewModel
{
    public Guid Id { get; set; }
    public Guid AlunoTurmaId { get; set; }
    public Guid AvaliacaoId { get; set; }
    public int Nota { get; set; }
    public DateTime Data { get; set; }
}
