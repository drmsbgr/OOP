namespace StudentManagementApp.Models
{
    public class Student(string? firstName, string? lastName, string? department, int? no) : ICloneable, IFormattable
    {
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string? Department { get; set; } = department;
        public int? No { get; set; } = no;

        public object Clone()
        {
            return new Student(FirstName, LastName, Department, No);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return format switch
            {
                "1" => $"Ad-Soyad: {FirstName} {LastName?.ToUpper()}",
                "2" => $"Ad-Soyad: {FirstName} {LastName?.ToUpper()} - Bölüm: {Department}",
                _ => $"Ad-Soyad: {FirstName} {LastName?.ToUpper()} - No: {No} - Bölüm: {Department}",
            };
        }
    }
}