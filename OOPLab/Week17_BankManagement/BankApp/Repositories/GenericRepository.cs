using Microsoft.EntityFrameworkCore;

namespace BankApp.Repositories;
public abstract class GenericRepository<T> where T : class, new()
{
    protected readonly BankingContext _context;
    public abstract DbSet<T>? TargetSet { get; }

    public GenericRepository(BankingContext context)
    {
        _context = context;
    }

    public virtual void Add(T entity)
    {
        TargetSet?.Add(entity);
        _context.SaveChanges();
    }

    public virtual void Delete(T entity)
    {
        TargetSet?.Remove(entity);
        _context.SaveChanges();
    }

    public virtual List<T> GetAll()
    {
        if (TargetSet is null) return [];
        return [.. TargetSet];
    }

    public virtual T? GetById(int id)
    {
        return TargetSet?.Find(id);
    }

    public abstract void Update(int id, T entity);
}