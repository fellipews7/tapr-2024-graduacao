namespace Domain.Entities;

public class Turma
{
    public Guid Id { get; set; }
    public Guid DisciplinaId { get; set; }
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }

    public Disciplina Disciplina { get; set; }
    public ICollection<Avaliacao> Avaliacoes { get; set; }
    public ICollection<AlunoTurma> Alunos { get; set; }
    public ICollection<Aula> Aulas { get; set; }
}
