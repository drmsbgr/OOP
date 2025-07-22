namespace BankApp.Entities;

public class Bank
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public ICollection<Customer>? Customers { get; set; }
}