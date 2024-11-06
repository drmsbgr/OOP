using System.Collections;

namespace ConsoleApp.Data;

public class MyCollection
{
    private readonly List<int> numbers = [];
    public List<int> Numbers => numbers;

    public MyCollection(params int[] coll) => numbers.AddRange(coll);

    public void Add(int value) => numbers.Add(value);
    public void Sort() => numbers.Sort();

    public int Count => numbers.Count;

}