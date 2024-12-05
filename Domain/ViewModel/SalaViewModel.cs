using Domain.Enum;

namespace Domain.ViewModel;

public class SalaViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public int Capacidade { get; set; }
    public EnumTipoSala Tipo { get; set; }

    public ICollection<AulaViewModel> Aulas { get; set; }
}
