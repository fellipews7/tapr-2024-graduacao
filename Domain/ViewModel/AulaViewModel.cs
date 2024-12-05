namespace Domain.ViewModel;

public class AulaViewModel
{
    public Guid Id { get; set; }
    public Guid TurmaId { get; set; }
    public Guid SalaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }

    public ICollection<AlunoPresencaViewModel> AlunosPresenca { get; set; }
}
