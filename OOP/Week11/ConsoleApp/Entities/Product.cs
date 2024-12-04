namespace ConsoleApp.Entities;

public class Product(int id, string? name, decimal cost) : IComparable<Product>
{
    public int Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public decimal Cost { get; set; } = cost;

    public int CompareTo(Product? other)
    {
        return other is null ? throw new ArgumentNullException(nameof(other)) : Cost.CompareTo(((Product)other).Cost);
    }

    public override string ToString()
    {
        return $"{Name} - {Cost:c}";
    }
}