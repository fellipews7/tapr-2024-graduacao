namespace Domain.Entities;

public class Aula
{
    public Guid Id { get; set; }
    public Guid TurmaId { get; set; }
    public Guid SalaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }

    public Turma Turma { get; set; }
    public Sala Sala { get; set; }
    public ICollection<AlunoPresenca> AlunosPresenca { get; set; }
}
