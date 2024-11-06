namespace ConsoleApp.Data;

public class Employee(int id, string? firstName, string? lastName, decimal salary) : IComparable<Employee>
{
    public int Id { get; set; } = id;
    public string? FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public decimal Salary { get; set; } = salary;
    public string? FullName => $"{FirstName} {LastName?.ToUpper()}";

    public int CompareTo(Employee? other)
    {
        return other.Salary.CompareTo(Salary);
    }
}