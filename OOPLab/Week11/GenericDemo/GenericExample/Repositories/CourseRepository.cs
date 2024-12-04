using GenericExample.Entities;

namespace GenericExample.Repositories;

public class CourseRepository : GenericRepository<Course>
{
    public Course? Search(int code)
    {
        return Get().FindAll(c => c.Code.ToString().Contains(code.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
    }
}