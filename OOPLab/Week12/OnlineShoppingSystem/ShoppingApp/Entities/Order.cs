namespace ShoppingApp.Entities;

public class Order
{
    public int Id { get; set; }
    public required Customer Customer { get; set; }
    public List<Product> Products { get; set; } = [];
    public decimal TotalPrice { get; set; }

    public override string ToString()
    {
        return $"ID:{Id,-5} CUSTOMER:{Customer}";
    }
}