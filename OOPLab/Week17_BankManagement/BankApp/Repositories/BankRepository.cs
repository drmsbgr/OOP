using BankApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repositories;

public class BankRepository : GenericRepository<Bank>
{
    public BankRepository(BankingContext context) : base(context)
    {
    }

    public override DbSet<Bank>? TargetSet => _context.Banks;

    public override void Update(int id, Bank entity)
    {
        var target = GetById(id);
        if (target is null) return;
        target.Name = entity.Name;
        target.Address = entity.Address;
        _context.SaveChanges();
    }
}
