using Specification.DP.Models;
using Specification.DP.Specifications;

namespace Specification.DP.Repositories;

public class ProductRepository
{
    // Fake in-memory database
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "iPhone", Brand = "Apple", Price = 1000 },
        new Product { Id = 2, Name = "MacBook", Brand = "Apple", Price = 2500 },
        new Product { Id = 3, Name = "Galaxy", Brand = "Samsung", Price = 900 },
        new Product { Id = 4, Name = "Dell XPS", Brand = "Dell", Price = 1800 }
    };

    public IEnumerable<Product> GetAll(ISpecification<Product> specification)
    {
        return _products
            .AsQueryable()
            .Where(specification.Criteria)
            .ToList();
    }
}
