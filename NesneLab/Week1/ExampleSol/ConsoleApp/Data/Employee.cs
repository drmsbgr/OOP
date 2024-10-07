namespace ConsoleApp.Data
{
    public class Employee(string firstName, string lastName, int age, decimal salary)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; } = age;
        public decimal Salary { get; set; } = salary;

        public override string ToString()
        {
            return $"{FullName}\nYaş:{Age}\nMaaş:{Salary} TL\n";
        }
    }
}
