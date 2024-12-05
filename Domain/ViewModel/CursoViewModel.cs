using Domain.Enum;

namespace Domain.ViewModel;

public class CursoViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public EnumTipoCurso Tipo { get; set; }

    public ICollection<DisciplinaViewModel> Disciplinas { get; set; }
}
