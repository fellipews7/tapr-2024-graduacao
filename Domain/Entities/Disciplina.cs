namespace Domain.Entities;

public class Disciplina
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public long CargaHoraria { get; set; }
    public Guid CursoId { get; set; }

    public Curso Curso { get; set; }
    public ICollection<Turma> Turmas { get; set; }
}
