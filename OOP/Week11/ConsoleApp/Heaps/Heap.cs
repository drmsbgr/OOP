using System.Collections;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Heaps;

public abstract class Heap<T> : IHeap<T> where T : IComparable<T>
{
    protected List<T?> items = [];
    public int Count => items.Count;

    public void Add(T item) => items.Add(item);
    public abstract T? Extract();

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}