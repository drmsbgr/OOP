namespace GenericExample.Repositories;

public class GenericRepository<T>
{
    private readonly List<T> items = [];
    public void Add(T entity) => items.Add(entity);
    public void Delete(T entity) => items.Remove(entity);
    public void Update(T old, T updated)
    {
        var index = items.FindIndex(x => x.Equals(old));
        if (index == -1)
            return;
        items[index] = updated;
    }
    public List<T> Get() => items;
}