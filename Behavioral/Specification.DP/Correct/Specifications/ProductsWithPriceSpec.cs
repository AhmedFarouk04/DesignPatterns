using Specification.DP.Models;

namespace Specification.DP.Specifications;

public class ProductsWithPriceSpec : BaseSpecification<Product>
{
    public ProductsWithPriceSpec(decimal minPrice)
        : base(p => p.Price >= minPrice)
    {
    }
}
