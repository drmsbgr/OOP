using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.Entities;

[PrimaryKey(nameof(Id))]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Product()
    {
        
    }

    public Product(int id, string name, decimal price, int stock) : this(name, price, stock)
    {
        Id = id;
    }
    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}