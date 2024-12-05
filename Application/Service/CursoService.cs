using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class CursoService : ServiceBase<Curso>, ICursoService
{
    public CursoService(DatabaseContext context) : base(context)
    {
    }
}
