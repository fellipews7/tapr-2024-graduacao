using Domain.Entities;

namespace Domain.ViewModel;

public class DisciplinaViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public long CargaHoraria { get; set; }
    public Guid CursoId { get; set; }

    public Curso Curso { get; set; }
    public ICollection<TurmaViewModel> Turmas { get; set; }
}
