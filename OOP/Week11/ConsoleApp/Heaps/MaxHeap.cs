namespace ConsoleApp.Heaps;

public class MaxHeap<T> : Heap<T> where T : IComparable<T>
{
    public override T? Extract()
    {
        var item = items.Max();
        items.Remove(item);
        return item;
    }
}