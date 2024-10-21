namespace ConsoleApp.Collections.Heap;

public class MaxHeap<T> : Heap<T> where T : IComparable
{
    public override T Extract()
    {
        // var max = values.Max();
        // values.Remove(max);
        // return max;

        var max = Values[0];

        foreach (T item in Values)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }

        Values.Remove(max);
        return max;
    }
}