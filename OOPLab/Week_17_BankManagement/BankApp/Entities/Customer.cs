namespace BankApp.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int BankId { get; set; }
    public Bank? Bank { get; set; }
    public ICollection<Account>? Accounts { get; set; }
}
