using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
{
    public DisciplinaService(DatabaseContext context) : base(context)
    {
    }
}
