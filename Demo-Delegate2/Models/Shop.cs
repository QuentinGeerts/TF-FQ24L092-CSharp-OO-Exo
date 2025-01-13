namespace Demo_Delegate2.Models;

delegate bool FilterPredicate (KeyValuePair<Product, int> kvp);

internal class Shop
{
    private readonly Dictionary<Product, int> _products = new Dictionary<Product, int>();

    public Shop(Dictionary<Product, int> products)
    {
        _products = products;
    }

    public Product[] Products => _products.Keys.ToArray();

    //public Product[] Products
    //{
    //    get
    //    {
    //        return _products.Keys.ToArray();
    //    }
    //}

    public decimal Buy(Product product, int quantity)
    {
        if (!_products.ContainsKey(product)) throw new ArgumentOutOfRangeException(nameof(product), "Product not found in shop");
        if (_products[product] < quantity) throw new ArgumentOutOfRangeException(nameof(quantity), "Not enough stock");

        decimal total = product.Price * quantity;
        _products[product] -= quantity;

        return total;
    }

    public Product[] FilterProduct(string name)
    {
        List<Product> products = new List<Product>();

        foreach (Product product in Products)
        {
            if (product.Name.ToLower().Contains(name.ToLower()))
            {
                products.Add(product);
            }
        }

        return products.ToArray();
    }

    public Product[] FilterAvailableProduct()
    {
        List<Product> products = new List<Product>();
        foreach (KeyValuePair<Product, int> kvp in _products)
        {
            if (kvp.Value > 0)
            {
                products.Add(kvp.Key);
            }
        }
        return products.ToArray();
    }

    public Product[] FilterProductByCategory(string category)
    {
        List<Product> products = new List<Product>();
        foreach (KeyValuePair<Product, int> kvp in _products)
        {
            if (kvp.Key.Categories.Contains(category))
            {
                products.Add(kvp.Key);
            }
        }
        return products.ToArray();
    }

    public Product[] FilterProductByPrice(decimal minPrice, decimal maxPrice)
    {
        List<Product> products = new List<Product>();
        foreach (KeyValuePair<Product, int> kvp in _products)
        {
            if (kvp.Key.Price >= minPrice && kvp.Key.Price <= maxPrice)
            {
                products.Add(kvp.Key);
            }
        }
        return products.ToArray();
    }

    public Product[] FilterProduct (FilterPredicate predicate)
    {
        List<Product> products = new List<Product>();
        foreach (KeyValuePair<Product, int> kvp in _products)
        {
            if (predicate(kvp))
            {
                products.Add(kvp.Key);
            }
        }
        return products.ToArray();
    }

}