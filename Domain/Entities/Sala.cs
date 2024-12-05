using Domain.Enum;

namespace Domain.Entities;

public class Sala
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public int Capacidade { get; set; }
    public EnumTipoSala Tipo { get; set; }

    public ICollection<Aula> Aulas { get; set; }
}
