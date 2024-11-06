using System.Collections;

namespace ConsoleApp.Data;

public class EmployeeCollection : IEnumerable<Employee>
{
    private readonly List<Employee> employees = [];

    public EmployeeCollection(params Employee[] employees)
    {
        this.employees.AddRange(employees);
    }

    public void Add(Employee employee) => employees.Add(employee);

    public IEnumerator<Employee> GetEnumerator() => employees.GetEnumerator();

    public void Sort()
    {
        employees.Sort();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}