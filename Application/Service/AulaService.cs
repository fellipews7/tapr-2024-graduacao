using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class AulaService : ServiceBase<Aula>, IAulaService
{
    public AulaService(DatabaseContext context) : base(context)
    {
    }
}
