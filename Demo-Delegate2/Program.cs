using Demo_Delegate2.Models;

Shop shop = new Shop(
    new Dictionary<Product, int>()
    {
        { new Product("Dell Vostro", 599M, ["Informatique", "Ordinateur", "Professionnel"]), 10 },
        { new Product("HP Pavilion", 499M, ["Informatique", "Ordinateur", "Personnel"]), 5 },
        { new Product("Dell Moinsbon", 499M, ["Informatique", "Ordinateur", "Professionnel"]), 3 },
        { new Product("Eau", 2M, ["Alimentaire", "Boisson", "Naturelle"]), 0 },
        { new Product("Coca-Cola", 1.5M, ["Alimentaire", "Boisson", "Gazeuse"]), 8 },
        { new Product("Pain", 0.5M, ["Alimentaire", "Boulangerie", "Naturelle"]), 0 },
        { new Product("Switch", 450M, ["Informatique", "Console", "Jeux-vidéo", "Maison"]), 3 },
        { new Product("PS5", 499M, ["Informatique", "Console", "Jeux-vidéo", "Maison"]), 2 },
        { new Product("Xbox Series X", 499M, ["Informatique", "Console", "Jeux-vidéo", "Maison"]), 1 },
    }
);

foreach (Product p in shop.Products)
{
    Console.WriteLine($" - {p}");
}

Console.WriteLine($"> Filtre sur le nom d'un produit");
Console.WriteLine($"Quels produits voulez-vous garder ?");
string productName = Console.ReadLine();

Product[] products = shop.FilterProduct(productName);

foreach (Product p in products)
{
    Console.WriteLine($" - {p}");
}


Console.WriteLine($"> Filtre sur les produits disponibles");
Product[] availableProducts = shop.FilterAvailableProduct();

foreach (var p in availableProducts)
{
    Console.WriteLine($" - {p}");
}



Console.WriteLine($"> Filtre sur le nom d'un produit (delegate) :");
FilterPredicate filterName = delegate (KeyValuePair<Product, int> kvp)
{
    return kvp.Key.Name.ToLower().Contains(productName.ToLower());
};

Product[] products2 = shop.FilterProduct(filterName);

Product[] products3 = shop.FilterProduct(delegate (KeyValuePair<Product, int> kvp)
{
    return kvp.Key.Name.ToLower().Contains(productName.ToLower());
});

Product[] products4 = shop.FilterProduct(kvp => kvp.Key.Name.ToLower().Contains(productName.ToLower()));
Product[] availableProducts2 = shop.FilterProduct(kvp => kvp.Value > 0);