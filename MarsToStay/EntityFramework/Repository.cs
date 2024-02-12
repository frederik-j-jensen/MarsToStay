namespace MarsToStay.EntityFramework;
public class Repository<T> where T : Entity, new()
{
    private readonly Dictionary<Guid, T> _entities = [];
    public async Task<T?> FindById(Guid id)
    {        
        if (_entities.TryGetValue(id, out var entity))
            return await Task.FromResult(entity);
        return null;
    }

    public async Task<T?> FindById(string id)
    {
        return await FindById(new Guid(id));
    }

    public async Task<T> Create()
    {
        var entity = new T();
        _entities.Add(entity.Id, entity);
        return await Task.FromResult(entity);
    }

}
