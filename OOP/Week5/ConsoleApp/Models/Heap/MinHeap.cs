namespace ConsoleApp.Models.Heap;

public class MinHeap<T> : Heap<T> where T : IComparable
{
    private readonly List<T> values = [];

    public override int Count => values.Count;
    public override void Add(T value) => values.Add(value);
    public override T Extract()
    {
        // var min = values.Min();
        // values.Remove(min);
        // return min;

        var min = values[0];

        foreach (T item in values)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }

        values.Remove(min);
        return min;
    }
}