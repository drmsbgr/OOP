using BankApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repositories;

public class CustomerRepository : GenericRepository<Customer>
{
    public CustomerRepository(BankingContext context) : base(context)
    {
    }

    public override DbSet<Customer>? TargetSet => _context.Customers;

    public override void Update(int id, Customer entity)
    {
        var target = GetById(id);
        if (target is null) return;
        target.FullName = entity.FullName;
        target.Email = entity.Email;
        _context.SaveChanges();
    }
}