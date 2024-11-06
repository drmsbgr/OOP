namespace UniversityApp.Models;

public class DoctorateStudent : Student
{
    public string? ResearchSubject { get; set; }

    public DoctorateStudent(string? firstName, string? lastName, int no, string? researchSubject) : base(firstName, lastName, no)
    {
        ResearchSubject = researchSubject;
    }

    public DoctorateStudent(string? firstName, string? lastName, int no, string? department, string? researchSubject) : base(firstName, lastName, no, department)
    {
        ResearchSubject = researchSubject;
    }

    public override string GetInfo()
    {
        return $"--------------------\n{FirstName} {LastName?.ToUpper()}\nNo: {No}, Bölüm: {Department}, Araştırma Konusu: {ResearchSubject}\n--------------------";
    }

    public void GetAdvisorReport()
    {
        Console.WriteLine("rapor.....");
    }
}