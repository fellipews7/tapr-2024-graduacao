using Application.Interface;
using Application.Repository;
using Data.Context;
using Domain.Entities;

namespace Application.Service;

public class SalaService : ServiceBase<Sala>, ISalaService
{
    public SalaService(DatabaseContext context) : base(context)
    {
    }
}
