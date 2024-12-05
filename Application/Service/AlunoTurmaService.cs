using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class AlunoTurmaService : ServiceBase<AlunoTurma>, IAlunoTurmaService
{
    public AlunoTurmaService(DatabaseContext context) : base(context)
    {
    }
}
