using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class TurmaService : ServiceBase<Turma>, ITurmaService
{
    public TurmaService(DatabaseContext context) : base(context)
    {
    }
}
