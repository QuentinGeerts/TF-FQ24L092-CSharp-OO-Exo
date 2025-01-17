using Demo_Generic02.Interfaces;

namespace Demo_Generic02.Models;

public class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
