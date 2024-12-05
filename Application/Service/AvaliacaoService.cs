using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class AvaliacaoService : ServiceBase<Avaliacao>, IAvaliacaoService
{
    public AvaliacaoService(DatabaseContext context) : base(context)
    {
    }
}
