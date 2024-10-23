namespace ConsoleApp.Models;

public class Student(int number, string? fullName, double gPA) : IComparable<Student>
{
    public int Number { get; set; } = number;
    public string? FullName { get; set; } = fullName;
    public double GPA { get; set; } = gPA;

    public int CompareTo(Student? other)
    {
        return GPA.CompareTo(other?.GPA);
    }
}