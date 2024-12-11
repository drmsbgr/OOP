namespace ShoppingApp.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"ID:{Id,-5} NAME:{Name,-10} PRICE:{Price.ToString("C"):-5}";
    }
}