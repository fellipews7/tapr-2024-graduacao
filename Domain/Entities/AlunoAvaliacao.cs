namespace Domain.Entities;

public class AlunoAvaliacao
{
    public Guid Id { get; set; }
    public Guid AlunoTurmaId { get; set; }
    public Guid AvaliacaoId { get; set; }
    public int Nota { get; set; }
    public DateTime Data { get; set; }

    public AlunoTurma AlunoTurma { get; set; }
    public Avaliacao Avaliacao { get; set; }
}
