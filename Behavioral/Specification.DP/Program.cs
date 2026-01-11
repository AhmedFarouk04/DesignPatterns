using Specification.DP.Repositories;
using Specification.DP.Specifications;

Console.WriteLine("=== Specification Pattern (Correct) ===");

var repository = new ProductRepository();

var appleSpec = new ProductsByBrandSpec("Apple");
var expensiveSpec = new ProductsWithPriceSpec(1500);

var appleProducts = repository.GetAll(appleSpec);
var expensiveProducts = repository.GetAll(expensiveSpec);

Console.WriteLine("\nApple Products:");
foreach (var product in appleProducts)
{
    Console.WriteLine($"- {product.Name} ({product.Price})");
}

Console.WriteLine("\nExpensive Products:");
foreach (var product in expensiveProducts)
{
    Console.WriteLine($"- {product.Name} ({product.Price})");
}
