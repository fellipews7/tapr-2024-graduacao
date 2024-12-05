using Data.Context;
using Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Application.Repository;

public class ServiceBase<T> : IServiceBase<T> where T : class
{
    protected DatabaseContext _context;

    public ServiceBase(DatabaseContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public IQueryable<T> Query()
    {
        return _context.Set<T>().AsNoTracking();
    }

    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(predicate);
    }

    public async Task<T> FirstAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().FirstAsync(predicate);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().AnyAsync(predicate);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}
