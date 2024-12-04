using GenericExample.Entities;

namespace GenericExample.Repositories;

public class StudentRepository : GenericRepository<Student>
{
    public Student? Search(string name)
    {
        return Get().FindAll(x => x.FullName.Contains(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
    }
}