using BankApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repositories;

public class BankingContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<Bank>? Banks { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source = app.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Transaction>().HasData(
            new Transaction()
            {
                Id = 1,
                AccountId = 1,
                Amount = 25000,
                Date = new(2023, 5, 23)
            },
            new Transaction()
            {
                Id = 2,
                AccountId = 1,
                Amount = 27000,
                Date = new(2024, 6, 20)
            }
        );

        modelBuilder.Entity<Account>().HasData(
            new Account()
            {
                Id = 1,
                AccountNo = 1001,
                Balance = 52000,
                CustomerId = 1,
            }
        );

        modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                Id = 1,
                FullName = "Buğra DURMUŞ",
                Email = "drmsbgr@gmail.com",
                BankId = 1
            }
        );

        modelBuilder.Entity<Bank>().HasData(
            new Bank()
            {
                Id = 1,
                Name = "Çiftlik Bank",
                Address = "Uruguay Mah, zort no'lu Sk",
            });
    }
}