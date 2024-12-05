using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class AlunoAvaliacaoService : ServiceBase<AlunoAvaliacao>, IAlunoAvaliacaoService
{
    public AlunoAvaliacaoService(DatabaseContext context) : base(context)
    {
    }
}
