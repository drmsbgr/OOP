namespace ConsoleApp.Collections.Heap;

public abstract class Heap<T>
{
    protected List<T> Values { get; } = [];
    public int Count => Values.Count;
    public void Add(T item) => Values.Add(item);
    public abstract T Extract();
}