namespace Domain.ViewModel;

public class AvaliacaoViewModel
{
    public Guid Id { get; set; }
    public Guid TurmaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Peso { get; set; }

    public ICollection<AlunoAvaliacaoViewModel> NotasAlunos { get; set; }
}
