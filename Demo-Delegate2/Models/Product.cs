namespace Demo_Delegate2.Models;

internal class Product
{
    public Product(string name, decimal price, string[] categories)
    {
        Name = name;
        Price = price;
        Categories = categories;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public string[] Categories { get; private set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Categories: {string.Join(", ", Categories)}";
    }
}
