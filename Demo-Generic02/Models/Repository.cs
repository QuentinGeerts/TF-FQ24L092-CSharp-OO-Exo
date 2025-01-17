using Demo_Generic02.Interfaces;

namespace Demo_Generic02.Models;


// where T : BaseEntity => Le type T doit hériter de BaseEntity
// where T : IEntity => Le type T doit implémenter IEntity
// where T : new() => Le type T doit avoir un constructeur par défaut
public class Repository<T> where T : BaseEntity, IEntity, new()
{
    private readonly List<T> _entities = new(); // Inférence de type (C# 9)

    public void Add(T entity)
    {
        _entities.Add(entity);
        Console.WriteLine($"[Add] Id: {entity.Id}, Name: {entity.Name}");
    }

    public T? FindById<U> (U id) where U : struct
    {
        foreach (T entity in _entities)
        {
            if (entity.Id.Equals(id))
            {
                Console.WriteLine($"[FindById] Id: {entity.Id}, Name: {entity.Name}");
                return entity;
            }
        }
        return default;
    }
}
