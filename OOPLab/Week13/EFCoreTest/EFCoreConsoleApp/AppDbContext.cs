using EFCoreConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasKey(p => p.Id);
        modelBuilder.Entity<Product>().HasData(new Product(1, "Mouse", 150, 25), new Product(2, "Keyboard", 300, 15), new Product(3, "Monitor", 2500, 10));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}