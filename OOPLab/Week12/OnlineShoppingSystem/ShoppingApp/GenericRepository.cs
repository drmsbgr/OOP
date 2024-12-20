using ShoppingApp.Entities;

namespace ShoppingApp;

public class GenericRepository<T> where T : class
{
    private readonly List<T> _items = [];
    public T Add(T item)
    {
        _items.Add(item);
        Console.WriteLine($"ADDED: {item}");
        return item;
    }
    public void Remove(T item)
    {
        Console.WriteLine($"REMOVED: {item}");
        _items.Remove(item);
    }
    public List<T> GetAll() => _items;
    // public T FindById(int id)
    // {
    //     return null;
    // }
}