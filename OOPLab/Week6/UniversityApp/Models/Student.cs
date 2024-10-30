namespace UniversityApp.Models;

public abstract class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int No { get; set; }
    public string? Department { get; set; }

    public Student(string? firstName, string? lastName, int no)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.No = no;
    }

    public Student(string? firstName, string? lastName, int no, string? department)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.No = no;
        this.Department = department;
    }

    public abstract string GetInfo();
}