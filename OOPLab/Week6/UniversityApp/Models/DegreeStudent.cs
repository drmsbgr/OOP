namespace UniversityApp.Models;

public class DegreeStudent : Student
{
    public string? Advisor { get; set; }
    public DegreeStudent(string? firstName, string? lastName, int no, string? advisor) : base(firstName, lastName, no)
    {
        Advisor = advisor;
    }

    public DegreeStudent(string? firstName, string? lastName, int no, string? department, string? advisor = null) : base(firstName, lastName, no, department)
    {
        Advisor = advisor;
    }

    public override string GetInfo()
    {
        return $"--------------------\n{FirstName} {LastName?.ToUpper()}\nNo: {No}, Bölüm: {Department}, Danışman: {Advisor}\n--------------------";
    }
}