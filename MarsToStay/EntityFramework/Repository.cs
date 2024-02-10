namespace MarsToStay.EntityFramework;
public class Repository<T> where T : Entity, new()
{
    private readonly Dictionary<string, T> _entities = [];
    public T? FindById(Guid id)
    {
        if (_entities.TryGetValue(id.ToString(), out var entity))
            return entity;
        return null;
    }

    public T Create()
    {
        var entity = new T();
        _entities.Add(entity.Id.ToString(), entity);
        return entity;
    }

}
