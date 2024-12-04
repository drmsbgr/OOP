namespace GenericExample.Entities;

public class Student(int ıd, string? firstName, string? lastName)
{
    public int Id { get; set; } = ıd;

    public string? FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public string? FullName => $"{FirstName} {LastName?.ToUpper()}";

    public override string ToString()
    {
        return $"{FirstName,-12} {LastName,-12}";
    }
}