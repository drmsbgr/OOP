using BankApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repositories;

public class AccountRepository : GenericRepository<Account>
{
    public AccountRepository(BankingContext context) : base(context)
    {

    }

    public override DbSet<Account>? TargetSet => _context.Accounts;

    public override void Update(int id, Account entity)
    {
        var target = GetById(id);
        if (target is null) return;
        target.AccountNo = entity.AccountNo;
        target.Balance = entity.Balance;
        _context.SaveChanges();
    }
}