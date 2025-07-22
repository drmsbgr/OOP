namespace BankApp.Entities;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public int AccountId { get; set; }
    public Account? Account { get; set; }
}