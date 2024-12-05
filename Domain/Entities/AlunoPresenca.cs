using Domain.Enum;

namespace Domain.Entities;

public class AlunoPresenca
{
    public Guid Id { get; set; }
    public Guid AlunoTurmaId { get; set; }
    public Guid AulaId { get; set; }
    public EnumPresenca Presenca { get; set; }

    public AlunoTurma AlunoTurma { get; set; }
    public Aula Aula { get; set; }
}
