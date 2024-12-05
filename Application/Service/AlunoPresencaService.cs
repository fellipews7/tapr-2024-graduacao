using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class AlunoPresencaService : ServiceBase<AlunoPresenca>, IAlunoPresencaService
{
    public AlunoPresencaService(DatabaseContext context) : base(context)
    {
    }
}
