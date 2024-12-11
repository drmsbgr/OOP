namespace ShoppingApp.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

    public Customer(int id, string fullName, string email)
    {
        this.Id = id;
        FullName = fullName;
        Email = email;
    }

    public override string ToString()
    {
        return $"ID:{Id,-5} FULLNAME:{FullName,-10} EMAIL:{Email,-10}";
    }
}