using Specification.DP.Models;

namespace Specification.DP.Wrong;

public class ProductService
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "iPhone", Brand = "Apple", Price = 1000 },
        new Product { Id = 2, Name = "MacBook", Brand = "Apple", Price = 2500 },
        new Product { Id = 3, Name = "Galaxy", Brand = "Samsung", Price = 900 }
    };

    public IEnumerable<Product> GetProducts(string brand, decimal minPrice)
    {
        return _products
            .Where(p => p.Brand == brand && p.Price >= minPrice)
            .ToList();
    }
}
