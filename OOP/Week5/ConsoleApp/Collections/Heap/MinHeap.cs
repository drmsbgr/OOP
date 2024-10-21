namespace ConsoleApp.Collections.Heap;

public class MinHeap<T> : Heap<T> where T : IComparable
{
    public override T Extract()
    {
        // var min = values.Min();
        // values.Remove(min);
        // return min;

        var min = Values[0];

        foreach (T item in Values)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }

        Values.Remove(min);
        return min;
    }
}