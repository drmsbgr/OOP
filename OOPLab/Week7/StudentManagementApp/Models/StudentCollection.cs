using System.Collections;

namespace StudentManagementApp.Models;

public class StudentCollection : ICollection<Student>
{
    private readonly List<Student> _students = [];

    public Student this[int index] => _students[index];
    public int Count => _students.Count;

    public bool IsReadOnly => true;

    public void Add(Student item)
    {
        _students.Add(item);
    }

    public void Clear()
    {
        _students.Clear();
    }

    public bool Contains(Student item)
    {
        return _students.Contains(item);
    }

    public void CopyTo(Student[] array, int arrayIndex)
    {
        _students.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Student> GetEnumerator()
    {
        return _students.GetEnumerator();
    }

    public bool Remove(Student item)
    {
        return _students.Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}