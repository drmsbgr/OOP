namespace ConsoleApp.Models.Heap;

public abstract class Heap<T>
{
    public abstract int Count { get; }
    public abstract void Add(T item);
    public abstract T Extract();
}