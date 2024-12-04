namespace ConsoleApp.Interfaces;

public interface IHeap<T> : IEnumerable<T> where T : IComparable<T>
{
    int Count { get; }
    void Add(T item);
    T? Extract();
}