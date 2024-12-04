namespace ConsoleApp.Heaps;

public class MinHeap<T> : Heap<T> where T : IComparable<T>
{
    public override T? Extract()
    {
        var item = items.Min();
        items.Remove(item);
        return item;
    }
}