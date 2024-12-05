using Domain.Enum;

namespace Domain.ViewModel;

public class AlunoPresencaViewModel
{
    public Guid Id { get; set; }
    public Guid AlunoTurmaId { get; set; }
    public Guid AulaId { get; set; }
    public EnumPresenca Presenca { get; set; }
}
