namespace Domain.Entities;

public class Avaliacao
{
    public Guid Id { get; set; }
    public Guid TurmaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Peso { get; set; }

    public Turma Turma { get; set; }
    public ICollection<AlunoAvaliacao> NotasAlunos { get; set; }
}
