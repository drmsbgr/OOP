namespace UniversityApp.Models;

public class LicenceStudent : Student
{
    public int Semester { get; set; }
    public LicenceStudent(string? firstName, string? lastName, int no, int semester) : base(firstName, lastName, no)
    {
        Semester = semester;
    }

    public LicenceStudent(string? firstName, string? lastName, int no, string? department, int semester = 0) : base(firstName, lastName, no, department)
    {
        Semester = semester;
    }

    public override string GetInfo()
    {
        return $"--------------------\n{FirstName} {LastName?.ToUpper()}\nNo: {No}, Bölüm: {Department}, Yarıyıl: {Semester}\n--------------------";
    }

    public void PrintSubjects()
    {
        Console.WriteLine("ders1\nders2\nders3");
    }
}