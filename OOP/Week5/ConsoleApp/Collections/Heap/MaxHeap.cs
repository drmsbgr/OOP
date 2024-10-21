namespace ConsoleApp.Collections.Heap;

public class MaxHeap<T> : Heap<T> where T : IComparable
{
    private readonly List<T> values = [];

    public override int Count => values.Count;

    public override void Add(T value) => values.Add(value);
    public override T Extract()
    {
        // var max = values.Max();
        // values.Remove(max);
        // return max;

        var max = values[0];

        foreach (T item in values)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }

        values.Remove(max);
        return max;
    }
}