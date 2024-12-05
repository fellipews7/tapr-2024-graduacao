using Domain.Enum;

namespace Domain.Entities;

public class Curso
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public EnumTipoCurso Tipo { get; set; }

    public ICollection<Disciplina> Disciplinas { get; set; }
}
