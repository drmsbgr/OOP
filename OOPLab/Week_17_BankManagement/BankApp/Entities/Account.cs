namespace BankApp.Entities;

public class Account
{
    public int Id { get; set; }
    public int AccountNo { get; set; }
    public decimal Balance { get; set; }
    public List<Transaction>? Transactions { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
}
